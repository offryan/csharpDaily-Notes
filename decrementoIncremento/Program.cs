using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decrementoIncremento
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Operadores de Incremento e Decremento

            int num1 = 10;
            // ++num1; 
            // --num1;

            Console.WriteLine(++num1);  // pré-incremento: incrementa antes de mostrar o valor
            Console.WriteLine(num1++); // pós-incremento: mostra o valor antes de incrementar
            Console.WriteLine(num1); // valor após o incremento

            Console.ReadKey();
        }
    }
}
