using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_test
{
    class NodeFunction : Node
    {

        private String _name;
        private Node[] _args;

        //calling a function from 'Methods.cs' needs the name of the function and an array of nodes as input arguments
        public NodeFunction(String name, Node[] args)
        {
            _name = name;
            _args = args;
        }

        //calculate the value by calling 'execFunc' from the context-class, and giving it the arguments (as numerical values)
        public override double Eval(IContext context)
        {
            double[] args = new double[_args.Length];

            //turning the array of nodes into an array of doubles; function arguments are numerical values
            for (int i=0; i<_args.Length; i++)
            {
                args[i] = _args[i].Eval(context);
            }

            return context.execFunc(_name, args);
        }
    }
}
