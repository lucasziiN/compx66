using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stars_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of stars to draw in a row:");
            int num_rows = int.Parse(Console.ReadLine());
            int num_columns = num_rows;

            for (int i = 0; i < num_rows; i++)
            {
                for (int j = 0; j < num_columns; j++)
                {
                    if (i == j)
                    {
                        Console.Write("_");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                    
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
