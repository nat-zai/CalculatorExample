using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            int ans = calc.Add(10, 84);
            Console.WriteLine("10 + 84 is (0).", ans);
            Console.ReadLine();
        }
    }
}
