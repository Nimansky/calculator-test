using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_test
{
    class NodeBinaryOp : Node
    {

        Node _left;
        Node _right;
        Func<double, double, double> _op;

        public NodeBinaryOp(Node left, Node right, Func<double, double, double> op)
        {
            _left = left;
            _right = right;
            _op = op;
        }

        public override double Eval()
        {
            double leftNum = _left.Eval();
            double rightNum = _right.Eval();

            double result = _op(leftNum, rightNum);
            return result;
        }
    }
}
