using System;

namespace Properties
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var person = new Person(new DateTime(1983, 8, 31));
            Console.WriteLine(person.Age);
        }
    }
}
