using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_test
{
    //The context interface
    public interface IContext
    {
        double getVar(String name);
        double execFunc(String name, double[] args);
    }
}
