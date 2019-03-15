using System.Collections.Generic;

namespace Exercicio1.Dominio
{
    public static class Recursividade
    {
        private static List<string> vogais = new List<string> { "a", "e", "i", "o", "u" };

        //1.
        public static int Fatorial(int n)
        {
            if (n == 0)
                return 1;

            for (int x = (n - 1); x > 0; x--) //se repete n-1 vezes
                n *= x; //O(1)

            return n;
        }
        //Custo: F(n) = n - 1
        //Classe: F(n) = O(n)

        public static int FatorialRecursivo(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * FatorialRecursivo(n - 1);
        }
        //Custo: F(n) = (n - 1) + 1
        //S(n) = S(n-1) + 1 
        //Classe: F(n) = O(n)
        
        //2.
        public static int Fibonacci(int n)
        {
            //Fn = Fn-1 + Fn-2

            int Fn = 0;
            int[] F = new int[n + 1];

            //Por definição, temos que:
            F[0] = F[1] = 1;

            //Calculando F(2) em diante...
            for (int i = 2; i < F.Length; i++) //se repete n-1 vezes
            {
                F[i] = F[i - 1] + F[i - 2]; //O(1)
                Fn = F[i]; //O(1)                  x 2
            }

            return Fn;
        }
        //Custo: F(n) = 2n - 2
        //Classe: F(n) = O(n)

        public static int FibonacciRecursivo(int n)
        {
            if (n < 2)
                return 1;
            else
                return FibonacciRecursivo(n - 1) + FibonacciRecursivo(n - 2);
        }
        //Custo: F(n) = (n-1) + (n-2) = 2n - 3
        //S(n) = S(n-1) + S(n-2) + 1
        //Classe: F(n) = O(n)

        //3.
        public static string TiraVogal(string frase)
        {
            string fraseFinal = string.Empty;

            for (int i = 0; i < frase.Length; i++) //se repete n vezes
                if (!vogais.Contains(frase[i].ToString().ToLower())) fraseFinal += frase[i]; //O(1)

            return fraseFinal;
        }
        //Custo: F(n) = n
        //Classe: F(n) = O(n)

        public static string TiraVogalRecursivo(string frase, int last)
        {
            if (last < 0)
                return frase;
            else if (vogais.Contains(frase[last].ToString().ToLower()))
                return TiraVogalRecursivo(frase.Replace(frase[last].ToString(), ""), (last - 2));
            else
                return TiraVogalRecursivo(frase, (last - 1));
        }
        //Custo: F(n) = n
        //Classe: F(n) = O(n)
        
        //4.
        public static int SomaDiagonais(int[,] mat)
        {
            int soma = 0, j = mat.GetLength(1) - 1;

            for (int i = 0; i < mat.GetLength(0); i++) //se repete n vezes
            {
                soma += mat[i, i] + mat[i, j]; //O(1)
                j--; //O(1)                           x 2
            }

            return soma;
        }
        //Custo: F(n) = 2n
        //Classe: F(n) = O(n)

        public static int SomaDiagonaisRecursivo(int[,] mat, int n)
        {
            if (n < 2)
                return mat[0, 0] + mat[0, mat.GetLength(1) - 1];
            else
                return mat[n - 1, n - 1] + mat[n - 1, mat.GetLength(1) - n] + SomaDiagonaisRecursivo(mat, n - 1);
        }
        //Custo: F(n) = (n-1) + 2
        //S(n) = S(n-1) + 2
        //Classe: F(n) = O(n)

        // -------------------------------------------------------------------------------------------------------
        
        //5) Calcule as funções de complexidade dos algoritmos a seguir:

        //a)
        public int alg5(int[] a, int x) {
            int low = 0;
            int high = a.length - 1;
            while (low <= high) {
                int mid = (low + high)/2;
                if (a[mid] == x) return mid;
                else if (a[mid] < x) low = mid + 1;
                else high = mid - 1;
            }
            return -1;
        }
        //Melhor caso: f(n) = 1
        //Pior caso: f(n) = log N + 1
        //Caso médio: f(n) = log N + 2 / 2
        
        //b) 
        public void alg6(int[] intArray){
            int temp, j;
            for (int i = 1; i < intArray.Length; i++){ //se repete n-1 vezes
                temp = intArray[i]; //1
                j = i - 1; //2
                while (j >= 0 && intArray[j] > temp){
                    intArray[j + 1] = intArray[j];
                    j--;
                }
                intArray[j + 1] = temp; //3
            }
        }
        //Melhor caso: f(n) = 3(n - 1)
        //Pior caso: f(n) = (n - 1)(n + 3) = n^2 + 2n - 3
        //Caso médio: f(n) = (n^2) - 5n/2

    }
}
