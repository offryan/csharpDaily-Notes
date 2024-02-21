using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodosDasClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metodos m = new Metodos();

            /*          Métodos Simples

                        m.Cumprimentar();
                        m.Somar(10, 40);
                        m.Apresentar("Ryan",21);
            */

            /* Parâmentros por valor e referência
            int valor1 = 100;
            int valor2 = 100;

            m.AumentarValor(valor1); // Por valor
            m.AumentarRef(ref valor2); // Por referência
            Console.WriteLine("Valor 1: " + valor1);
            Console.WriteLine("Valor 2: " + valor2);
                        */

            /* Métodos com retorno de valores
            string nomeCompleto =  m.MontaNome("Ryan", "Gomes");
            int codigoChar = m.CodigoChar('r');
            double pi = m.PI();

            Console.WriteLine("Nome completo: " + nomeCompleto);
            Console.WriteLine("Código Char: " + codigoChar);
            Console.WriteLine("Valor de PI: " + pi);
            */

            Console.ReadKey();
        }
    }
}