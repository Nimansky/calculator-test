using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_test
{
    class calcbutton : Button
    {
        //a normal button but with one additional property: the "InputSymbol"
        //the InputSymbol gives information about which symbols  are to actually be printed on the label, since it does not always correspond to the button text
        private String inputsymbol;
        public String InputSymbol
        {
            get { return inputsymbol; }
            set { inputsymbol = value; }
        }
    }
}
