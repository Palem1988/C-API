using System;
namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello World!");
            stringUtility.StringLibrary clsString = new stringUtility.StringLibrary ();
            Console.WriteLine(clsString.StartsWithUpper("kts"));
            Console.WriteLine(clsString.IsStringPalindrome("12321"));
        }
    }
}
