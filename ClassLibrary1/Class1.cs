using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public double input1 { get; set; }
        public double input2 { get; set; }


        public double add()
        {
            return input1 + input2;
        }

        public double less()
        {
            return input1 - input2;
        }

        public double mul()
        {
            return input1 * input2;
        }
        public double div()
        {
            return input1 / input2;
        }
        public double remainder()
        {
            return input1 % input2;
        }
    }
}
