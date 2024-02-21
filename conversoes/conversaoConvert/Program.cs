using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string txt = Convert.ToString(2500);

            double num1 = Convert.ToDouble(false);

            int num2 = Convert.ToInt32('C'); // utiliza as aspas simples

            Console.WriteLine(txt);
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.ReadKey();
        }
    }
}
