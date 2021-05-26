using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write("m=");
            m = int.Parse(Console.ReadLine());

            int[,] A = new int[n, m];
            Random r = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    A[i, j] = r.Next(0, 100);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(A[i, j] + " ");
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m / 2; j++)
                {
                    int t = A[i, j];
                    A[i, j] = A[i, m - 1 - j];
                    A[i, m - 1 - j] = t; ;
                }



            Console.WriteLine("Новый массив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(A[i, j] + " ");
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
