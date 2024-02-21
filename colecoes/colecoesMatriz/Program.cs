using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colecoesMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] nomes =
            {
                {"Ryan", "Luan", "Brian" },
                {"Murilo", "Kawan", "Junior"}
            };

            int[,] num =
            {
                {10, 20, 30},
                {40, 50, 60}
            };

            Console.WriteLine(nomes[1,0]);
            Console.WriteLine(num[0,2]);
            Console.ReadKey();
        }
    }
}
