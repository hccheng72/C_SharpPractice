using System;

namespace Exercise6
{
    class Program
    {
        static void Main()
        {
            int i, j, r;
            do
            {
                Console.Write("Enter the number of rows (positive number): ");
                r = Convert.ToInt32(Console.ReadLine());
            } while (r <= 0);

            for (i = 0; i <= r; i++)
            {
                for (j = 1; j <= r - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.WriteLine("");
            }

            for (i = r - 1; i >= 1; i--)
            {
                for (j = 1; j <= r - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.WriteLine("");
            }
        }
    }
}
