﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace multiplicacaoMatrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] matriz1 = new int[2, 3];
            int[,] matriz2 = new int[3, 2];
            int[,] result = new int[2, 2];

            Console.WriteLine("Preencha a 1º matriz: ");

            for (int linha = 0; linha < 2; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    Console.WriteLine("#1. Posição [" + linha + "][" + coluna + "]: ");
                    matriz1[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nPreencha a 2º matriz: ");

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    Console.WriteLine("#2. Posição [" + linha + "][" + coluna + "]: ");
                    matriz2[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nResultado da 1º matriz x 2º matriz");
            result[0, 0] =
           (matriz1[0, 0] * matriz2[0, 0]) +
           (matriz1[0, 1] * matriz2[1, 0]) +
           (matriz1[0, 2] * matriz2[2, 0]);

            result[1, 0] =
           (matriz1[1, 0] * matriz2[0, 0]) +
           (matriz1[1, 1] * matriz2[1, 0]) +
           (matriz1[1, 2] * matriz2[2, 0]);

            result[0, 1] =
          (matriz1[0, 0] * matriz2[0, 1]) +
          (matriz1[0, 1] * matriz2[1, 1]) +
          (matriz1[0, 2] * matriz2[2, 1]);

            result[1, 1] =
          (matriz1[1, 0] * matriz2[0, 1]) +
          (matriz1[1, 1] * matriz2[1, 1]) +
          (matriz1[1, 2] * matriz2[2, 1]);

            Console.WriteLine("[" + result[0, 0] + "][" + result[0, 1] + "]");
            Console.WriteLine("[" + result[1, 0] + "][" + result[1, 1] + "]");
            Console.ReadKey();
        }
    }
}
