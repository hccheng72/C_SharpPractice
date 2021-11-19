using System;

namespace Exercise5
{
    class Program
    {
        static void Main()
        {
            int row;
            do
            {
                Console.Write("Enter the number of rows (positive number): ");
                row = Convert.ToInt32(Console.ReadLine());
            } while (row <= 0);

            int n = 1;
            while (n <= row)
            {
                string s = "";
                for (int i = 0; i < n; i++)
                {
                    if (i % 2 == 0)
                        s += "1";
                    else
                        s += "0";
                }
                n++;
                Console.WriteLine(s);
            }
            

        }
    }
}
