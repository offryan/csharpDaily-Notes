using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int valor = 10;

            //if (valor >= 5 && valor < 10)
            //{
            //    Console.Write("Condicação 1");
            //}
            //else if (valor >= 10 && valor < 20)
            //{
            //    Console.Write("Condicação 2");
            //}
            //else if (valor >= 20 && valor < 30)
            //{
            //    Console.Write("Condicação 2");
            //}
            //else
            //{
            //    Console.Write("Condicação final");
            //}

            // ------------------------------//

            //int numero = 10;

            //if(numero > 5) 
            //{
            //    Console.Write("O número é maior que 5");

            //    if(numero % 2 == 0 )
            //    {
            //        Console.Write(" e par.");
            //    }
            //    else
            //    {
            //        Console.Write(" e ímpar.");
            //    }
            //}

            // ------------------------------//

            //int numero = 3;
            //string msg = ""; 

            //if (numero > 5)
            //{
            //    msg = "Mensagem maior que 5";
            //}
            //else
            //{
            //    msg = "Mensagem menor que 5";
            //}

            //msg = numero > 5 ? "Maior que 5" : msg = "Menor que 5";

            // ------------------------------//

            int num = 3;
            Console.Write (num > 5 ? "Maior que 5" : "Menor que 5");
            Console.ReadKey(); 
        }
    }
}
