using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int escolha = 1; // Switch com valor númerico

            switch (escolha)
            {
                default:
                    Console.WriteLine("Opção Default");
                    break;
                case 1:
                    Console.WriteLine("Opção 1");
                    break;
                case 2:
                    Console.WriteLine("Opção 1");
                    break;
                case 3:
                    Console.WriteLine("Opção 1");
                    break;
            }

            String escolha1 = "R"; // Switch com String

            switch (escolha1)
            {
                default:
                    Console.WriteLine("Opção Default");
                    break;
                case "N":
                    Console.WriteLine("Opção N");
                    break;
                case "A":
                    Console.WriteLine("Opção A");
                    break;
                case "Y":
                    Console.WriteLine("Opção Y");
                    break;
                case "R":
                    Console.WriteLine("Opção R");
                    break;
            }
            Console.ReadKey();
        }
    }
}
