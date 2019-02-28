using Exercicio1.Dominio;
using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Recursividade.FatorialRecursivo(4));
            //Console.WriteLine(Recursividade.FibonacciRecursivo(6));
            //Console.WriteLine(Recursividade.TiraVogalRecursivo("Algoritmos e Estruturas de dados")); // lgrtms strtrs d dds

            int[,] mat = new int[3, 3];

            mat[0, 0] = 7; mat[0, 1] = 10; mat[0, 2] = 4;
            mat[1, 0] = 12; mat[1, 1] = 5; mat[1, 2] = 9;
            mat[2, 0] = 2; mat[2, 1] = 8; mat[2, 2] = 11;

            //mat[0, 0] = 11; mat[0, 1] = 8; mat[0, 2] = 6; mat[0, 3] = 6;
            //mat[1, 0] = 0; mat[1, 1] = 2; mat[1, 2] = 17; mat[1, 3] = 1;
            //mat[2, 0] = 7; mat[2, 1] = 3; mat[2, 2] = 10; mat[2, 3] = -1;
            //mat[3, 0] = 9; mat[3, 1] = 5; mat[3, 2] = 12; mat[3, 3] = 7;

            //mat[0, 0] = 7; mat[0, 1] = 10;
            //mat[1, 0] = 4; mat[1, 1] = 14;

            Console.WriteLine(Recursividade.SomaDiagonais(mat));
            Console.WriteLine(Recursividade.SomaDiagonaisRecursivo(mat, 3));

            Console.ReadKey();

        }
    }
}
