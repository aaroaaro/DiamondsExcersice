using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace TimanttiHarjoitus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, n;

            while (true)
            {
                Console.Write("Enter the number of rows for half of the diamond: ");
                n = Convert.ToInt32(Console.ReadLine());

                
                for (i = 1; i <= n; i++)
                {
                    for (k = 1; k <= n - i; k++)
                    {
                        Console.Write(" ");
                    }
                    for (j = 1; j <= 2 * i - 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                
                for (i = n - 1; i >= 1; i--)
                {
                    for (k = 1; k <= n - i; k++)
                    {
                        Console.Write(" ");
                    }
                    for (j = 1; j <= 2 * i - 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                Console.Write("\nWould you like to create another diamond? (yes/no): ");
                string response = Console.ReadLine();
                if (response != "yes")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

            }

        }
    }
}
