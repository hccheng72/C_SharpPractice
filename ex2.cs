using System;

namespace Exercise2
{
    class Program
    {
        static void Main()
        {
            int choice = 0;
            do
            {
                Console.Write("number 1 = ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("number 2 = ");
                int y = Convert.ToInt32(Console.ReadLine());

                Console.Write("1: Add, 2: Subtract, 3: Multiply, 4: Divide\n" +
                              "Please enter the number of option: ");
                choice = Convert.ToInt32(Console.ReadLine()); //why can't use (int)

                Arithmetic operation = new Arithmetic(x, y);

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Sum = " + operation.Addtion());
                        break;
                    case 2:
                        Console.WriteLine("Subtraction = " + operation.Subtraction());
                        break;
                    case 3:
                        Console.WriteLine("Multiplication = " + operation.Multiplication());
                        break;
                    case 4:
                        if (y != 0)
                            Console.WriteLine("Division = " + operation.Division());
                        else
                            Console.WriteLine("Divisor can't be zero.");
                        break;
                    case 5:
                        Console.WriteLine("Bye Bye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;

                }
                Console.Clear();
            } while (choice != 5);
            
        }
    }

    class Arithmetic
    {
        int a, b;

        public Arithmetic(int x = 0, int y = 0)
        {
            a = x;
            b = y;
        }
        
        public int Addtion()
        {
            return a+b;
        }

        public int Subtraction()
        {
            return a - b;
        }

        public int Multiplication()
        {
            return a * b;
        }

        public double Division()
        {
            return (double)a / b;
        }
    }
}
