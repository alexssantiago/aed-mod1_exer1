using System.Collections.Generic;

namespace Exercicio1.Dominio
{
    public static class Recursividade
    {
        public static List<string> vogais = new List<string> { "a", "e", "i", "o", "u" };

        public static int Fatorial(int n)
        {
            if (n == 0)
                return 1;

            int fat = n;

            for (int x = (n - 1); x > 0; x--)
            {
                fat *= x;
            }

            return fat;
        }

        public static int FatorialRecursivo(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * FatorialRecursivo(n - 1);
        }

        public static int Fibonacci(int n)
        {
            //Fn = Fn-1 + Fn-2

            int Fn = 0;
            int[] F = new int[n + 1];

            //Por definição, temos que:
            F[0] = F[1] = 1;

            //Calculando F(2) em diante...
            for (int i = 2; i < F.Length; i++)
            {
                F[i] = F[i - 1] + F[i - 2];
                Fn = F[i];
            }

            return Fn;
        }

        public static int FibonacciRecursivo(int n)
        {
            if (n < 2)
                return 1;
            else
                return FibonacciRecursivo(n - 1) + FibonacciRecursivo(n - 2);
        }

        public static string TiraVogal(string frase)
        {
            string fraseFinal = string.Empty;

            foreach (char letra in frase)
            {
                if (!vogais.Contains(letra.ToString().ToLower()))
                    fraseFinal += letra;
            }

            return fraseFinal;
        }

        public static string TiraVogalRecursivo(string frase, int last)
        {
            if (last < 0)
                return frase;
            else if (vogais.Contains(frase[last].ToString().ToLower()))
                return TiraVogalRecursivo(frase.Replace(frase[last].ToString(), ""), (last - 2));
            else
                return TiraVogalRecursivo(frase, (last - 1));
        }

        public static int SomaDiagonais(int[,] mat)
        {
            int soma = 0, j = mat.GetLength(1) - 1;

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                soma += mat[i, i] + mat[i, j];
                j--;
            }

            return soma;
        }

        public static int SomaDiagonaisRecursivo(int[,] mat, int n)
        {
            if (n < 2)
                return mat[0, 0] + mat[0, mat.GetLength(1) - 1];
            else
                return mat[n - 1, n - 1] + mat[n - 1, mat.GetLength(1) - n] + SomaDiagonaisRecursivo(mat, n - 1);
        }

    }
}
