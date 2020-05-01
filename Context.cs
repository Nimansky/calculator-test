using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_test
{

    //the context class implementing the context interface, used to call functions and retrieve stored variables once called
    class Context : IContext
    {

        private object _lib;

        //once initialized, the context needs access to the 'Methods.cs' class to call functions and variables
        public Context(object lib)
        {
            _lib = lib;
        }

        //get variable value by looking for its name in the 'Methods.cs' class
        public double getVar(string name)
        {
            var variable = _lib.GetType().GetProperty(name);
            return (double)variable.GetValue(_lib);
        }

        //execute function by looking for its name in 'Methods.cs' and invoke
        public double execFunc(string name, double[] args)
        {
            var func = _lib.GetType().GetMethod(name);
            var argObjs = args.Select(x => (object)x).ToArray();
            return (double)func.Invoke(_lib, argObjs);
        }

    }
}
