using System;

namespace Properties
{
    public class Person
    {

        // AUTO IMPLEMENTED PROPERTIES
        public string Name { get; set; }
        public string Username { get; set; }
        public DateTime Birthdate { get; private set; }

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        public int Age   // not auto to use logic on bday given
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }
    }
}

// Properties use Pascal case
//      camel case is for _private
//      - auto implemented properties, C# creates get set 