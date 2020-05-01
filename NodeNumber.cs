using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace calculator_test
{
    class NodeNumber : Node
    {

        private double _number;

        //a number only needs its own value
        public NodeNumber(double number)
        {
            _number = number;
        }

        //just return the value
        public override double Eval(IContext context)
        {
            return _number;
        }
    }
}
