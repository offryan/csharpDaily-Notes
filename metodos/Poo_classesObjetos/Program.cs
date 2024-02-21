using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_classesObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pessoa p1 = new Pessoa()
            { nome = "Ryan", sobrenome = "Gomes", anoNascimento = 2002 };

            Pessoa p2 = new Pessoa()
            { nome = "Murilo", sobrenome = "Gomes", anoNascimento = 2007 };
            p2.sobrenome = "Paulino"; // Alteração de valor

            Pessoa p3 = new Pessoa()
            { nome = "Vitor", sobrenome = "Melo", anoNascimento = 2004 };
            p3.anoNascimento = 2008; // Método Cumprimentar

            Console.WriteLine();

            Console.WriteLine("Nome: " + p1.nome + " " + p1.sobrenome + " | Ano de Nascimento: " + p1.anoNascimento);
            p1.cumprimentar(); // Método Cumprimentar

            Console.WriteLine();

            Console.WriteLine("Nome: " + p2.nome + " " + p2.sobrenome + " | Ano de Nascimento: " + p2.anoNascimento);
            p2.cumprimentar(); // Método Cumprimentar

            Console.WriteLine();

            Console.WriteLine("Nome: " + p3.nome + " " + p3.sobrenome + " | Ano de Nascimento: " + p3.anoNascimento);
            p3.cumprimentar(); /// Método Cumprimentar

            Console.ReadKey();
        }
    }
}
