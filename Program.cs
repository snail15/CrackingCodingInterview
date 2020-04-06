using System;
using CrackingCodingInterview.ArraysAndString;

namespace CrackingCodingInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = "helo";
            var a = new IsUnique();
            System.Console.WriteLine(a.IsUniqueElement(test));
        }
    }
}
