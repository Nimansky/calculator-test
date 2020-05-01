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

        public Tokenizer(TextReader reader)
        {
            _reader = reader;
            nextChar();
            nextToken();
        }

        public Token Token
        {
            get { return _currToken; }
        }

        public char Character
        {
            get { return _currChar; }
        }

        public double Number
        {
            get { return _number; }
        }

        public void nextChar()
        {
            int chr = _reader.Read();
            _currChar = chr < 0 ? '\0' : (char)chr;
        }

        public void nextToken()
        {
            switch (_currChar)
            {
                case '\0':
                    nextChar();
                    _currToken = Token.EOF;
                    return;
                case '+':
                    nextChar();
                    _currToken = Token.Add;
                    return;
                case '-':
                    nextChar();
                    _currToken = Token.Subtract;
                    return;
                case '^':
                    nextChar();
                    _currToken = Token.Power;
                    return;
                case '*':
                    nextChar();
                    _currToken = Token.Multiply;
                    return;
                case '/':
                    nextChar();
                    _currToken = Token.Divide;
                    return;
                case '(':
                    nextChar();
                    _currToken = Token.OpenParens;
                    return;
                case ')':
                    nextChar();
                    _currToken = Token.CloseParens;
                    return;
                case '!':
                    nextChar();
                    _currToken = Token.Factorial;
                    return;
            }

            switch (_currChar)
            {
                case 'π':
                    _number = Math.PI;
                    _currToken = Token.Number;
                    nextChar();
                    return;
                case 'e':
                    _number = Math.E;
                    _currToken = Token.Number;
                    nextChar();
                    return;
                default:
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
                    return;
            }
        }
    }
}
