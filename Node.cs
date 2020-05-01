using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_test
{
    //abstract class for all kinds of nodes in the tree
    public abstract class Node
    {
        //calculate the numerical value of the node(be it an operation, a number or a variable)
        public abstract double Eval(IContext context);
    }
}
