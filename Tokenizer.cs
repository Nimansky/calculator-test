using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_test
{
    class Tokenizer
    {
        private char _currChar;
        private Token _currToken;
        private TextReader _reader;
        private double _number;
        private String _identifier;

        //initialize the Tokenizer, give it a StringReader as input
        public Tokenizer(TextReader reader)
        {
            _reader = reader;
            nextChar();
            nextToken();
        }

        //return the variable name, if the token is a variable
        public String Identifier
        {
            get { return _identifier; }
        }

        //return the token at the current position in string
        public Token Token
        {
            get { return _currToken; }
        }

        //return the character at the current position in string
        public char Character
        {
            get { return _currChar; }
        }

        //return the number, if the token is a number
        public double Number
        {
            get { return _number; }
        }

        //read the next character and save it, if it is not EndOfFile
        public void nextChar()
        {
            int chr = _reader.Read();
            _currChar = chr < 0 ? '\0' : (char)chr;
        }

        //save the next token (at current character)
        public void nextToken()
        {

            //check if current character is an operator or special token
            switch (_currChar)
            {
                case '\0': //end of file
                    nextChar();
                    _currToken = Token.EOF;
                    return;
                case '+': //addition
                    nextChar();
                    _currToken = Token.Add;
                    return;
                case '-': //subtraction
                    nextChar();
                    _currToken = Token.Subtract;
                    return;
                case '^': //power
                    nextChar();
                    _currToken = Token.Power;
                    return;
                case '*': //multiplication
                    nextChar();
                    _currToken = Token.Multiply;
                    return;
                case '/': //division
                    nextChar();
                    _currToken = Token.Divide;
                    return;
                case '(': //open parenthesis
                    nextChar();
                    _currToken = Token.OpenParens;
                    return;
                case ')': //closing parenthesis
                    nextChar();
                    _currToken = Token.CloseParens;
                    return;
                case '!': //factorial
                    nextChar();
                    _currToken = Token.Factorial;
                    return;
                case ';': //semicolon (to seperate arguments in functions such as log(x,y))
                    nextChar();
                    _currToken = Token.Semicolon;
                    return;
            }

            //check if current character is a number, a variable/function, or a constant
            switch (_currChar)
            {
                case 'π': //constant pi
                    _number = Math.PI;
                    _currToken = Token.Number;
                    nextChar();
                    return;
                case 'e': //constant euler's number
                    _number = Math.E;
                    _currToken = Token.Number;
                    nextChar();
                    return;
                default: //numbers, variables, functions

                    //numbers with decimal points, displayed as commas (German notation)
                    if (char.IsDigit(_currChar) || _currChar == ',')
                    {
                        StringBuilder sb = new StringBuilder();
                        bool HasCommaAlready = false;
                        while (char.IsDigit(_currChar) || (!HasCommaAlready && _currChar == ','))
                        {
                            sb.Append(_currChar);
                            HasCommaAlready = _currChar == ',';
                            nextChar();
                        }
                        _number = Double.Parse(sb.ToString(), CultureInfo.GetCultureInfo("de-DE"));
                        _currToken = Token.Number;

                        //check if there's an e or a pi after the number, if so, multiply by the constant and skip their characters 
                        //(so we don't unnecessarily tokenize them)
                        if (_currChar == 'e')
                        {
                            nextChar();
                            _number *= Math.E;
                        }
                        else if (_currChar == 'π')
                        {
                            nextChar();
                            _number *= Math.PI;
                        }
                        return;
                    }

                    //variables and functions
                    if (char.IsLetter(_currChar))
                    {
                        //store the full name of the variable or function in '_identifier' and skip their characters
                        var sb = new StringBuilder();

                        while (char.IsLetter(_currChar))
                        {
                            sb.Append(_currChar);
                            nextChar();
                        }

                        _identifier = sb.ToString();
                        _currToken = Token.Identifier;
                        return;
                    }
                    return;
            }
        }
    }
}
