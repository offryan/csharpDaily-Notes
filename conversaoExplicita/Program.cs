using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversaoExplicita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Na Conversão explícita, é preciso forçar o dado a mudar de tipo, podendo levar a perca de dados

            ushort num1 = 500;
            ushort num2 = 700f; // Há perca de dados - R:600 - invés de 700
            byte num3 = (byte)num1; // Há perca de dados - R: 244 - invés de 500

            float num4 = 2500.999f; // Perca das casas decimais - R: 2500 - invés de 2500,999
            int num6 = (int)17.102f; //Perca das casas decimais - Resulta: 17 - invés de 17,102
            int num5 = (int)num3; // exemplo com uma váriavel invés da forma literal
            char letra = (char)97; // Resulta: a

            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num6); 
            Console.WriteLine(letra);
            Console.ReadKey();
        }
    }
}
