using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcularIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Repasse o peso em kg: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Repasse a altura em metros: ");
            double altura = double.Parse(Console.ReadLine());

            double IMC = peso / (altura * altura);

            if (IMC < 20)
            {
                Console.Write("\n IMC = " + IMC + " Está abaixo do peso: ");
            }
            else if ((IMC >= 20) && (IMC <= 24))
            {
                Console.Write("\n IMC = " + IMC + " Está no peso ideal: ");
            }
            else if ((IMC >= 25) && (IMC <= 29))
            {
                Console.Write("\n IMC = " + IMC + " Está acima do peso ideal: ");
            }
            else if ((IMC >= 30) && (IMC <= 34))
            {
                Console.Write("\n IMC = " + IMC + " Está obeso(a) ");
            }
            else
            {
                Console.Write("\n IMC = " + IMC + "Está muito obeso(a) ");
            }
            Console.ReadKey();
        }
    }
}
