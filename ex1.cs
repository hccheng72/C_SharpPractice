using System;

namespace DemoTask
{
    class Program
    {
        static void Main()
        {
            Student s1 = new Student();
            s1.GetData();
            s1.DisplayData();
            Console.ReadKey();
        }
    }

    class Student
    {
        string name, address;
        int mobile;

        public void GetData()
        {
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("Enter your address: ");
            address = Console.ReadLine();
            Console.Write("Enter your mobile: ");
            mobile = Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayData()
        {
            Console.WriteLine("Student name: " + name);
            Console.WriteLine("Student address: " + address);
            Console.WriteLine("Studnet Mobile: " + mobile);
        }
    }
}
