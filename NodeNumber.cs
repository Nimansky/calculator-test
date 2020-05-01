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

        public NodeNumber(double number)
        {
            _number = number;
        }

        public override double Eval()
        {
            return _number;
        }
    }
}
