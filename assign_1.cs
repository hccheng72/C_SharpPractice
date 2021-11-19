using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CAssignment cAssignment = new CAssignment();
            int[] arr = { 1, 2, 3 };
            cAssignment.RepeatArray(arr);
        }
    }


    class CAssignment
    {
        public void RepeatArray(int[] arr)
        {
            int[] doubleArr = arr.Concat(arr).ToArray();
            foreach (int n in doubleArr)
                Console.Write(n + " ");
        }
    }
}
