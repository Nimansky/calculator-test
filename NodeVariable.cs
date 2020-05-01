using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_test
{
    class NodeVariable : Node
    {

        private String _varname;

        //a variable needs its name to be called
        public NodeVariable(String name)
        {
            _varname = name;
        }

        //return the numerical value by calling 'getVar' form the context-class and giving it the variable's name
        public override double Eval(IContext context)
        {
            return context.getVar(_varname);
        }
    }
}
