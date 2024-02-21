using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversaoImplicita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Conversão implicíta = quando uma váriavel de um tipo suporta a atribuição de outro tipo de outra váriavel, criando troca de tipos sem perca de dados.

            byte num1 = 10; // 8 bits: 0  á 255
            ushort num2; // 16 bits: 0 á 65.535
            long num5 = num1; // 16 bits

            float num3 = 1710.99f; // 4 bits
            double num4 = num3; // 8 bits

            num2 = num1;
            num4 = num5;
            // num5 = num3; //Conversão explícita
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
