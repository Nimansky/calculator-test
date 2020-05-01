using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_test
{
    class NodeUnaryOp : Node
    {

        private Func<double, double> _op;
        private Node _rightside;

        public NodeUnaryOp(Node rightside, Func<double, double> op)
        {
            _rightside = rightside;
            _op = op;
        }

        public override double Eval()
        {
            double rightside = _rightside.Eval();

            double result = _op(rightside);
            return result;
        }
    }
}
