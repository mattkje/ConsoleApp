using System;

namespace ConsoleApplicationTest
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            User user = new User("Mike", 34);
            Console.WriteLine(user.GetName() + user.GetAge());
        }
    }

    public class User
    {
        private string _name;

        private int _age;

        public User(string name, int age)
        {
            this._name = name;
            this._age = age;
        }
        
        public string GetName()
        {
            return this._name;
        }
        
        public int GetAge()
        {
            return this._age;
        }
    }
}