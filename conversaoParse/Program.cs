using System;

namespace conversaoParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Conversão de string para valor númerico com Parse
            // Gera erro caso aja letras na string

            string txtNumero = "2024";

            int numero = int.Parse(txtNumero);

            byte num1 = byte.Parse("102");

            double num2 = double.Parse("1249,53"); // Vírgula em vez do ponto, se não printará como o número 124953.

            float num3 = float.Parse("1717,17"); // Float não precisa da letra f

            Console.WriteLine(numero);
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.ReadKey();
        }
    }
}
