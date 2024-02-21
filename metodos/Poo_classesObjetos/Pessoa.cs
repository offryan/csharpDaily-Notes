using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_classesObjetos
{
    internal class Pessoa
    { 
        // Atributos / Campos
        public string nome;
        public string sobrenome;
        public int anoNascimento;

        // Método simples
        public void cumprimentar()
        {
            Console.WriteLine("Olá, eu sou " + nome + " " + sobrenome);
        }
    }
}
