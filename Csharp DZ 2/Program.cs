using System;
using System.Globalization;
using System.Net.WebSockets;

namespace Csharp_DZ_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /// 1
            /*
             string[] arr1 = { "select", "main", "enter", "object", "reverse" };
            string[] arr2 = { "low", "enter", "cs", "c++", "main" };
            string[] arr3 = { "" };
            for (int i = 0; i < arr1.Length; i++)
            {
                int d = 0;
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        arr3[d] = arr1[i];
                        d++;
                    }
                }
            }
            for (int j = 0; j < arr3.Length; j++)
            {
                Console.WriteLine(arr3[j]);
            }
            /// 2
            Console.WriteLine("Enter text:");
            string word1 = Console.ReadLine();
            word1 = word1.ToLower();
            string newWord = "";
            for (int i = word1.Length - 1; i >= 0; i--)
            {
                newWord += word1[i];
            }
            if (word1 == newWord)
            {
                Console.WriteLine("This is a palindrome.");
            }
            else
            {
                Console.WriteLine("This is not a palindrome.");
            }
            /// 3
             string str = Console.ReadLine();
            string[] word = str.Split(' ');
            Console.WriteLine("Number of words in a sentence: "+word.Length);
             */
            /// 4
            int N = 10, M = 10;
            int[,] a = new int[N, M];
            Random random = new Random();
            int rand;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    rand = random.Next(10, 100);
                    a[i, j] = rand;
                }
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.Write("\n");
            }
            ///

        }
    }
}
