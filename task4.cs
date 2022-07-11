using System;

namespace homework___age_and_surname_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string age;
            string FullName;
            string color;
            Console.WriteLine("Enter your age:");
            age = Console.ReadLine();
            Console.WriteLine("Enter your full name:");
            FullName = Console.ReadLine();
            Console.WriteLine("Enter you favorite color");
            color = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hello " + FullName);
            Console.WriteLine("You age " + age + " years old");
            Console.WriteLine("Your favorite color " + color);
            
        }
    }
}
