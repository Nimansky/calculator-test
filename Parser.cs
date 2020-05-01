using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_test
{
    class Parser
    {

        private Tokenizer _tokenizer;
        private calculatorstuff cs = new calculatorstuff();

        public Parser(Tokenizer tokenizer)
        {
            _tokenizer = tokenizer;
        }

        private Node ParseLeaf()
        {
            if(_tokenizer.Token == Token.Number)
            {
                NodeNumber node = new NodeNumber(_tokenizer.Number);
                _tokenizer.nextToken();
                if(_tokenizer.Token == Token.Factorial)
                {
                    if (node.Eval() % 1 == 0)
                    {
                        Node newnode = new NodeNumber(cs.factorial((int)node.Eval()));
                        _tokenizer.nextToken();
                        return newnode;
                    }
                    else
                    {
                        throw new Exception($"Can't calculate factorial of decimal number: {node.Eval()}");
                    }
                }
                return node;
            }

            if(_tokenizer.Token == Token.OpenParens)
            {
                _tokenizer.nextToken();
                Node node = ParseAddSubtract();
                if (_tokenizer.Token != Token.CloseParens)
                {
                    throw new Exception("Missing closing parenthesis");
                }
                _tokenizer.nextToken();
                if (_tokenizer.Token == Token.Factorial)
                {
                    if (node.Eval() % 1 == 0)
                    {
                        Node newnode = new NodeNumber(cs.factorial((int)node.Eval()));
                        _tokenizer.nextToken();
                        return newnode;
                    }
                    else
                    {
                        throw new Exception($"Can't calculate factorial of decimal number: {node.Eval()}");
                    }
                }
                return node;
            }

            throw new Exception($"Unexpected token: {_tokenizer.Token}");
        }

        private Node ParseUnary()
        {
            while (true)
            {
                if (_tokenizer.Token == Token.Add)
                {
                    _tokenizer.nextToken();
                    continue;
                }

                if (_tokenizer.Token == Token.Subtract)
                {
                    _tokenizer.nextToken();
                    Node rightside = ParseUnary();
                    return new NodeUnaryOp(rightside, (a) => -a);
                }

                return ParseLeaf();
            }
        }

        private Node ParseMultiplyDivide()
        {
            Node leftside = ParseUnary();

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

                if (op == null)
                {
                    return leftside;
                }

                _tokenizer.nextToken();
                Node rightside = ParseUnary();

                leftside = new NodeBinaryOp(leftside, rightside, op);
            }
        }

        private Node ParseAddSubtract()
        {
            Node leftside = ParseMultiplyDivide();

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

                if (op == null)
                {
                    return leftside;
                }

                _tokenizer.nextToken();
                Node rightside = ParseMultiplyDivide();

                leftside = new NodeBinaryOp(leftside, rightside, op);
            }
        }


        public Node ParseExpression()
        {
            Node expression = ParseAddSubtract();

            if(_tokenizer.Token != Token.EOF)
            {
                throw new Exception($"Unexpected characters in expression: {_tokenizer.Character}");
            }

            return expression;
        }


        public static Node Parse(Tokenizer tokenizer)
        {
            Parser parser = new Parser(tokenizer);
            return parser.ParseExpression();
        }

        public static Node Parse(string expression)
        {
            return Parse(new Tokenizer(new StringReader(expression)));
        }
    }
}
