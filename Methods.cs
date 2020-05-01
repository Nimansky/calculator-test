using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_test
{

    //This class contains all the math functions of the calculator to be invoked by the context interface
    class Methods
    {
        private double _ans;

        public Methods(double ans)
        {
            _ans = ans;
        }

        public double sin(double angle)
        {
            return Math.Sin((angle * Math.PI) / 180);
        }
        public double cos(double angle)
        {
            return Math.Cos((angle * Math.PI) / 180);
        }
        public double tan(double angle)
        {
            return Math.Tan((angle * Math.PI) / 180);
        }
        public double arcsin(double val)
        {
            return (Math.Asin(val)*180)/Math.PI;
        }
        public double arccos(double val)
        {
            return (Math.Acos(val) * 180) / Math.PI;
        }
        public double arctan(double val)
        {
            return (Math.Atan(val) * 180) / Math.PI;
        }
        public double log(double val, double bas)
        {
            return Math.Log(val, bas);
        }
        public double sqrt(double val)
        {
            return Math.Sqrt(val);
        }
        public double rt(double val, double bas)
        {
            return Math.Pow(val, (1 / bas));
        }
    }
}
