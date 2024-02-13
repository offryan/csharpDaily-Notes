using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace declaracaoGoto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Inicio: // --> Criação de um lable
            Console.Write("Escolha uma opção: ");

            int opcao = int.Parse(Console.ReadLine());
            int valor = 0; 

            switch (opcao)
            {
                default:
                    goto Inicio; // --> Caso seja escolhida uma opc inválida ele retorna a pergunta
                case 1:
                    valor += 100;
                    break;
                case 2:
                    valor += 50;
                    goto case 1; // --> retorna para o case 1 e soma com o valor do case 2
            }

            Console.WriteLine("Valor final " + valor);
            Console.ReadKey();
        }
    }
}
