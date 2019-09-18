using System;

namespace deliverableMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name!");
            method();
        }
        //Custom method
        private static void method()
        {
            string input = Console.ReadLine();
            Console.WriteLine("Hello" + " " + input + "!");
            
        }
    }
}
