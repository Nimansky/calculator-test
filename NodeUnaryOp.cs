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

        //a unary operation (only negation in this case) needs its right hand side and the actual operation to execute
        public NodeUnaryOp(Node rightside, Func<double, double> op)
        {
            _rightside = rightside;
            _op = op;
        }

        //return numerical value by executing the operation given the numerical value of the right hand side 
        public override double Eval(IContext context)
        {
            double rightside = _rightside.Eval(context);

            double result = _op(rightside);
            return result;
        }
    }
}
