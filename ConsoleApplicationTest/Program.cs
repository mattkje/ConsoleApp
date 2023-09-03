using System;

namespace ConsoleApplicationTest
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your age:");
            string ageString = Console.ReadLine();
            
            if (int.TryParse(ageString, out var age))
            {
                var user = new User(name, age);
                Console.WriteLine("Your name is " + user.GetName() + " and you are " + user.GetAge() + " years old.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for age.");
            }
        }
    }
}