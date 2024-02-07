using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracoes
{
    // indexação de base 0, na sequencia colocada será definido um valor em ordem crescente 
    // Enumerações podem ser usadas para erros também
    internal class Program
    {
        enum Notas
        {
            Minimo = 0, 
            Media = 7, 
            Maxima = 10 
        }
        enum Error
        {
            Naoencontrado = 404,
            catchAll = 500,
            indisponivel = 503,
            GatewayTimeout = 504
        } 

        struct Pessoa
        {
            public string nome;
            public int idade;
            public double altura;
        }
        static void Main(string[] args)
        {
            Notas notasAlunos = Notas.Media; // Enum
            Error systemError = Error.catchAll; // Enum 

            Console.WriteLine("Notas de alunos usando enumeração");
            Console.WriteLine(notasAlunos);
            Console.WriteLine(systemError);
            Console.WriteLine();

            Pessoa p1 = new Pessoa(); // Struct
            p1.nome = "Ryan";
            p1.idade = 21;
            p1.altura = 1.81;
            Console.WriteLine();

            Pessoa p2 = new Pessoa() // Struct
            {
                nome = "Murilo",
                idade = 15,
                altura = 1.79,
            };

            p1.nome = " Substituto";

            Console.WriteLine("Criando pessoas usando struturação");
            Console.WriteLine("Dados da 1º pessoa: ");
            Console.WriteLine("Nome:" + p1.nome);
            Console.WriteLine("Idade: " + p1.idade);
            Console.WriteLine("Altura: " + p1.altura);
            Console.WriteLine();
            Console.WriteLine("Dados da 2º pessoa: ");
            Console.WriteLine("Nome: " + p2.nome);
            Console.WriteLine("Idade: " + p2.idade);
            Console.WriteLine("Altura: " + p2.altura);

            Console.ReadKey();
        }
    }
}
