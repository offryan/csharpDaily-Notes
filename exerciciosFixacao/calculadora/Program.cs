using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Inicio:
            Console.Clear();

            Console.WriteLine("-----Calculadora em C#--------");

            Console.Write("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Escolha a operação (+ - x /): ");
            char op = char.Parse(Console.ReadLine());

            double result = 0;

            switch (op)
            {
                default:
                    Console.WriteLine("Erro! Opção inválida");
                    break;
                case '+':
                    result = num1 + num2;
                    Console.WriteLine("O resultado da soma é: " + result);
                    break;
                case '-':
                    result = num2 - num1;
                    Console.WriteLine("O resultado da substração é: " + result);
                    break;
                case 'x':
                case 'X':
                    result = num2 * num1;
                    Console.WriteLine("O resultado da multiplicação é: " + result);
                    break;
                case '/':
                case ':':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Não é possível dividir por 0");
                    }
                    else
                    {
                        result = num2 / num1;
                        Console.WriteLine("O resultado da divisão é: " + result);
                    }
                    break;
            }

            Console.Write("Desja contunuar calculando (s / n)? ");
            string opcao = Console.ReadLine();

            if (opcao == "s" || opcao == "S")
            { 
                goto Inicio;
            }
            else
            {
                Console.ReadKey();
            }
        }
    }
}
