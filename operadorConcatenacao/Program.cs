using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace operadorConcatenacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Concatenaçãos
            string nome = "Ryan ";
            string sobrenome = " Gomes ";
            string nomeCompleto = nome + sobrenome + 2002;

            Console.WriteLine(nomeCompleto);
            Console.ReadKey();
        }
    }
}