using System;

namespace Lap
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Anh";
            person.PhoneNumber = 123456789;
            person.Email = "Anh@gmail.com";
            Console.WriteLine(person.ToString());
        }
    }
}