
using System;

namespace AccessModifiers
{
    public class Person
    {
        // OOP encapsulation / information hiding 
        private DateTime _birthdate; // cannot access outside person (_private)

        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(1982, 1, 1));
            Console.WriteLine(person.GetBirthdate());

        }
    }
}

// OOP encapsulation / information hiding
//      objects sould hide their information, provide properties for others to modify
//      property = getter setter