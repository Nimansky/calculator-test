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

        //Binary operations need a lefthand side, a righthand side, and an actual operation to execute
        public NodeBinaryOp(Node left, Node right, Func<double, double, double> op)
        {
            _left = left;
            _right = right;
            _op = op;
        }

        //return the value by executing the given function, with the numerical values of the right and left sides as input arguments
        public override double Eval(IContext context)
        {
            double leftNum = _left.Eval(context);
            double rightNum = _right.Eval(context);

            double result = _op(leftNum, rightNum);
            return result;
        }
    }
}
