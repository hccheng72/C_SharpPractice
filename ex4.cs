using System;

namespace Exercise4
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the first number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entere the second number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Armstrong Numbers between {n1} and {n2} are: ");
            for (int i = n1; i <= n2; i++)
            {
                int sum = 0, n = i;
                while (n != 0)
                {
                    int res = n % 10;
                    sum += (res * res * res);
                    n /= 10;
                }
                if (sum == i)
                    Console.WriteLine(i);
            }

        }
    }
}
