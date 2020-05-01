﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_test
{

    //a list of possible tokens for the tokenizer to use
    public enum Token
    {
        EOF,
        Add,
        Subtract,
        Multiply,
        Divide,
        OpenParens,
        CloseParens,
        Number,
        Power,
        Factorial,
        e,
        pi,
        Identifier,
        Semicolon
    }
}
