using System;

namespace Exercise3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            Console.WriteLine("The reversed string is " + (new StringManipulation()).ReverseString(input));
        }

        
    }

    class StringManipulation 
    {
        public string ReverseString(string s)
        {
            string ans = "";
            for (int i = s.Length - 1; i > -1; i--)
            {
                ans += s[i];
            }
            return ans;
        }
    }
}


