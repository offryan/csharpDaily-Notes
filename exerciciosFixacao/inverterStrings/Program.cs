using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inverterNomes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string aux, nome1, nome2, nome3, nome4;

            Console.WriteLine("Digite o 1º nome");
            nome1 = Console.ReadLine();

            Console.WriteLine("Digite o 2º nome");
            nome2 = Console.ReadLine();

            Console.WriteLine("Digite o 3º nome");
            nome3 = Console.ReadLine();

            Console.WriteLine("Digite o 4º nome");
            nome4 = Console.ReadLine();

            // Inversão de string

            aux = nome1;
            nome1 = nome4;
            nome4 = aux;
            aux = nome2;
            nome2 = nome3;
            nome3 = aux;

            Console.WriteLine();
            Console.WriteLine("Nomes inseridos na sequência invertida");
            Console.WriteLine(nome1);
            Console.WriteLine(nome2);
            Console.WriteLine(nome3);
            Console.WriteLine(nome4);
            Console.ReadKey();

        }
    }
}
