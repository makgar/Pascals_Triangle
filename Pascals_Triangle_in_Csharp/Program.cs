using System;

namespace Pascals_triangle_in_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n;
            Console.WriteLine("How many rows of Pascals's triangle do you want to see?");
            while ((!uint.TryParse(Console.ReadLine(), out n)) || n == 0)
            {
                Console.WriteLine(Environment.NewLine + "The value you have provided is not a positive integer." + Environment.NewLine + "Please try again.");
            }

            int[,] pT = new int[n + 1, n + 1];
            pT[1, 1] = 1;

            for (int i = 2; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    pT[i, j] = pT[i - 1, j] + pT[i - 1, j - 1];
                }
            }

            Console.WriteLine(Environment.NewLine + string.Format("Pascal's triangle until row {0} looks as follows:", n));
            //for (int i = 0; i <= n; i++)
            for (int i = 1; i <= n; i++)
            {
                //for (int j = 0; j <= n; j++)
                for (int j = 1; j <= i; j++)
                {
                    if (pT[i,j] != 0)
                    {
                        Console.Write(string.Format("{0} ", pT[i, j]));
                    }
                }
                Console.Write(Environment.NewLine);
            }
        }
    }
}
