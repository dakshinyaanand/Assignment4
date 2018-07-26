using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class NumericFormats
    {
        int intvalue;
        decimal decimalvalue;
        int evalue;

        public void printNumber(int number)
        {

            intvalue = number;
            Console.WriteLine("Given value:"+intvalue.ToString("N1", CultureInfo.InvariantCulture));
        }

        public void printMoney(int number)
        {

            decimalvalue = number;
            Console.WriteLine("Given Amount:" + decimalvalue.ToString("C", CultureInfo.CurrentCulture));
        }
        public void printHexaDecimal(int number)
        {
            evalue = number;
            Console.WriteLine("HexaDecimal :" + evalue.ToString("X"));
        }

        
    }
}
