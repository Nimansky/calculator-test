using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_test
{

    //this parser works via a tree-hierarchy of sorts: read the tokens, decide what exactly to classify them as (numbers, operators, ...),
    //create nodes in a tree and store them in there, then execute all necessary operations from 
    //bottom to top - every lower priority parsing function calls a higher priority parsing function
    class Parser
    {

        private Tokenizer _tokenizer;
        private calculatorstuff cs = new calculatorstuff();
        private Context _context;

        //initialize the parser by giving it a tokenizer and a context (implementing the context interface), so it can read the tokens and call variables/functions
        public Parser(Tokenizer tokenizer, Context context)
        {
            _tokenizer = tokenizer;
            _context = context;
        }

        //lowest of all nodes in the hierarchy (highest priority): numbers, parenthesis, variables 
        private Node ParseLeaf()
        {
            //if the token is a number, create a node for the number. also, return its factorial instead if there is a factorial-token right next to it
            if(_tokenizer.Token == Token.Number)
            {
                NodeNumber node = new NodeNumber(_tokenizer.Number);
                _tokenizer.nextToken();
                return ParseFactorial(node);
            }

            //if the token is an opening parenthesis, treat everything inside as a new expression and start from the top again;
            //also check for closing parenthesis and factorials
            if (_tokenizer.Token == Token.OpenParens)
            {
                _tokenizer.nextToken();
                Node node = ParseAddSubtract(); //starting by splitting the expression into nodes in a tree from the top again
                if (_tokenizer.Token != Token.CloseParens)
                {
                    throw new Exception("Missing closing parenthesis");
                }
                _tokenizer.nextToken();
                return ParseFactorial(node);
            }

            //if the token is a function or a variable, call said function or variable
            if (_tokenizer.Token == Token.Identifier)
            {
                //store the name of the variable, also create a node for it
                NodeVariable node = new NodeVariable(_tokenizer.Identifier);
                String name = _tokenizer.Identifier;
                _tokenizer.nextToken();

                //if the token after the variable is a opening parenthesis, it is a function (e.g. "cos("), if not, it is a variable
                if (_tokenizer.Token != Token.OpenParens)
                {
                    return ParseFactorial(node); //just return the variable in a node, or the factorial of it if there is an according operator right next to it
                }
                else  //if it is a function
                {
                    _tokenizer.nextToken();
                    List<Node> list = new List<Node>();
                    while (true)
                    {
                        //add the first thing inside the parenthesis to the argument list
                        list.Add(ParseAddSubtract());

                        //check if there's a semicolon, if there is, start the loop again and add the next argument
                        if(_tokenizer.Token == Token.Semicolon)
                        {
                            _tokenizer.nextToken();
                            continue;
                        }

                        //if there's no semicolon anymore, leave the loop
                        break;
                    }

                    //check if there's a closing parenthesis to close the function
                    if(_tokenizer.Token != Token.CloseParens)
                    {
                        throw new Exception("Missing closing parenthesis");
                    }
                    _tokenizer.nextToken();

                    //return the function in a node
                    return new NodeFunction(name, list.ToArray());
                }
            }

            //what do if token is not recognized
            throw new Exception($"Unexpected token: {_tokenizer.Token}");
        }

        //just a shortcut for checking if there's a factorial to be calculated, not technically a part of the tree
        private Node ParseFactorial(Node node)
        {
            //if there's a '!'...
            if (_tokenizer.Token == Token.Factorial)
            {
                //...and it's a whole number...
                if (node.Eval(_context) % 1 == 0)
                {
                    //return the calculated factorial as a number in a node
                    Node newnode = new NodeNumber(cs.factorial((int)node.Eval(_context)));
                    _tokenizer.nextToken();
                    return newnode;
                }
                else
                {
                    throw new Exception($"Can't calculate factorial of decimal number: {node.Eval(_context)}");
                }
            }
            else
            {
                //if there's no '!', just return the unprocessed node
                return node;
            }
        }

        //second lowest node in the hierarchy; second-highest priority: parsing unary operations (negating numbers, e.g. '-2' or '--2')
        private Node ParseUnary()
        {
            while (true)
            {
                //if the token is a plus, do nothing because it doesn't affect the number
                if (_tokenizer.Token == Token.Add)
                {
                    _tokenizer.nextToken();
                    continue;
                }

                //if the token is a minus, then parse the expression to the right of it
                if (_tokenizer.Token == Token.Subtract)
                {
                    _tokenizer.nextToken();

                    //calling "ParseUnary" recursively, so that double negation becomes possible '--2' = '+2'
                    Node rightside = ParseUnary();

                    //return the right side of the operator and the negation-operation in a node
                    return new NodeUnaryOp(rightside, (a) => -a);
                }

                //if there's no plus or minus left, go to 'ParseLeaf' (one down in the tree)
                return ParseLeaf();
            }
        }

        //Parsing Multiplication, Division, and Exponentiation; second highest in the hierarchy, second lowest in priority
        private Node ParseMultiplyDivide()
        {
            //Parse the left side of the expression
            Node leftside = ParseUnary();

            //assign a function according to the token
            while (true)
            {
                Func<double, double, double> op = null;
                if (_tokenizer.Token == Token.Multiply)
                {
                    op = (a, b) => a * b;
                }
                else if (_tokenizer.Token == Token.Divide)
                {
                    op = (a, b) => a / b;
                }
                else if (_tokenizer.Token == Token.Power)
                {
                    op = (a, b) => Math.Pow(a,b);
                }

                //if there is no operator, just return the parsed left side as is
                if (op == null)
                {
                    return leftside;
                }

                //also parse the right side
                _tokenizer.nextToken();
                Node rightside = ParseUnary();

                //return the two sides of the operator and the binary operation in a node, use it as the new left side (loop continues)
                leftside = new NodeBinaryOp(leftside, rightside, op);
            }
        }

        //highest in the hierarchy, lowest in priority: parse addition and subtraction
        private Node ParseAddSubtract()
        {
            //parse the left side of the operator
            Node leftside = ParseMultiplyDivide();

            //assign a function according to the operator
            while (true)
            {
                Func<double, double, double> op = null;
                if(_tokenizer.Token == Token.Add)
                {
                    op = (a, b) => a + b;
                }
                else if(_tokenizer.Token == Token.Subtract)
                {
                    op = (a, b) => a - b;
                }

                //if there's no operator, just return the parsed left side as is
                if (op == null)
                {
                    return leftside;
                }

                //also parse the right side
                _tokenizer.nextToken();
                Node rightside = ParseMultiplyDivide();

                //return the two sides of the operator and the binary operation in a node, use it as the new left side (loop continues)
                leftside = new NodeBinaryOp(leftside, rightside, op);
            }
        }

        //initial function to begin parsing
        public Node ParseExpression()
        {
            //begin parsing by starting from the top of the tree hierarchy
            Node expression = ParseAddSubtract(); 

            //check if EndOfFile is reached after parsing, if not => error
            if(_tokenizer.Token != Token.EOF)
            {
                throw new Exception($"Unexpected characters in expression: {_tokenizer.Character}");
            }

            //return the parsed node
            return expression;
        }

        //two methods of convenience: call Parse(string, context) to retrieve a parsed node from an input string
        public static Node Parse(Tokenizer tokenizer, Context context)
        {
            Parser parser = new Parser(tokenizer, context);
            return parser.ParseExpression();
        }

        public static Node Parse(string expression, Context context)
        {
            return Parse(new Tokenizer(new StringReader(expression)), context);
        }
    }
}
