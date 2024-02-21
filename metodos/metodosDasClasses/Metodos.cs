using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodosDasClasses
{
    internal class Metodos
    {
        // Métodos com Simples
        public void Cumprimentar()
        {
            Console.WriteLine("Olá, bom dia. ");
        }

        // Métodos com Parâmentros

        // Somar
        public void Somar(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("A soma é: " + result);
        }
        // Apresentar
        public void Apresentar(string nome, int idade)
        {
            Console.WriteLine("Meu nome é: " + nome + " e tenho " + idade + " anos");
        }

        // Parâmentros por valor

        public void AumentarValor(int valor)
        {
            valor += 10;
            Console.WriteLine("Valor final (por valor) é: " + valor);
        }

        // Parâmentros por referência
        public void AumentarRef(ref int valor)
        {
            valor += 10;
            Console.WriteLine("Valor final (por referência) é: " + valor);
        }

        // Métodos com retorno de valores
        public string MontaNome(string nome, string sobrenome)
        {
            // string nomeCompleto = nome + " " + sobrenome;
            // return nomeCompleto;

            return nome + " " + sobrenome; // Simplificado
        }

        public int CodigoChar(char caractere)
        {
            // int codigo = (int)caractere; -----> conversão redundante implicita
            return caractere;
        }

        public double PI()
        {
            return 3.1415;
        }

    }
}
