using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        public delegate void Num(int m);
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter the number");
            number = int.Parse(Console.ReadLine());
            NumericFormats n = new NumericFormats();
            Num nm=n.printNumber;
            nm+=n.printMoney;
            nm+=n.printHexaDecimal;
            nm(number);
        }
    }
}
