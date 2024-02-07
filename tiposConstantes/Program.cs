using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dar preferência para letras minúsculas, para usar menos memória

            float real1 = 100.75f; // 32 bits, usar o "F" e/ou "f"
            double real2 = -125.99; // Aceita números negativos e positvos 64 bits
            decimal real3 = 752548.453m; // usar o "M" e/ou "m" 128 bits 

            Console.WriteLine("Valores " +
                "Float: " + real1 + 
                "|  Double: " + real2 +
                "|  Decimal: " + real3);

            // Constantes são valores imútaveis

            const double pi = 3.1415;   
            const string name = "Ryan";

            Console.WriteLine(pi + name);
            Console.ReadKey();
        }
    }
}
