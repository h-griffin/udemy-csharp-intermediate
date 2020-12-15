

using System;

namespace Classes
{
    public class Person
    {
        // feild
        public string Name;

        // method
        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public static Person Parse(string str)
        {
            // object instance
            var person = new Person();
            person.Name = str;

            return person;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = Person.Parse("John"); // new person obj
            person.Introduce("Griffin");
        }
    }
}

// person           class
//
// name: stirng     data
// age : byte
// height: float
// weight
//                  behavior
// Walk()
// Talk()
// Eat()
// Sleep

// object - instance of class
// John - person obj

// instance - accessable from obj
//      var person = new Person();
//      person.Name = str;
// static - accessable from class
//      Console.WriteLine("Hi {0}, I am {1}", to, Name);

