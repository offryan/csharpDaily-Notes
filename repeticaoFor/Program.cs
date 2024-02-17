using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repeticaoFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0, j = 10; i < 10; i++, j--)
            //{
            //    Console.WriteLine("I = : " + i + " | J = " + j);
            //}

            string[] nomes = { "Maça","Pera","Banana","Uva" };

            foreach (string nome in nomes)
            {
                Console.WriteLine("Nome: " + nome);
            }

            Console.ReadKey();
        }
    }
}
