using System;

namespace Pascals_Triangle_in_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n, blank;
            Console.WriteLine("How many rows of Pascals's triangle do you want to see?");
            while ((!uint.TryParse(Console.ReadLine(), out n)) || n == 0)
            {
                Console.WriteLine(Environment.NewLine + "The value you have provided is not a positive integer." + Environment.NewLine + "Please try again.");
            }

            uint[,] pT = new uint[n + 1, n + 1];
            pT[1, 1] = 1;

            for (uint i = 2; i <= n; i++)
            {
                for (uint j = 1; j <= i; j++)
                {
                    pT[i, j] = pT[i - 1, j] + pT[i - 1, j - 1];
                }
            }

            Console.WriteLine(Environment.NewLine + string.Format("Pascal's triangle until row {0} looks as follows:", n));
            //for (int i = 0; i <= n; i++)
            for (uint i = 1; i <= n; i++)
            {
                for (blank = 1; blank <= n - i; blank++)
                {
                    Console.Write("  ");
                }
                //for (int j = 0; j <= n; j++)
                for (uint j = 1; j <= i; j++)
                {
                    if (pT[i,j] != 0)
                    {
                        Console.Write(string.Format("{0}   ", pT[i, j]));
                    }
                }
                Console.Write(Environment.NewLine);
            }
        }
    }
}
