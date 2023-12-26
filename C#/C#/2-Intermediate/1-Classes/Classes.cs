using System;

namespace C_.Intermediate._1_Classes
{

    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I'm {1}", to, Name);
        }

    }

    public class Person2
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I'm {1}", to, Name);
        }

        public static Person2 Parse(string str)
        {
            var person = new Person2();
            person.Name = str;
            return person;
        }

    }

    internal class Classes
    {
        //private static void Main(string[] args)
        //{
        //    // Pascal Case is naming convention for Class Names
        //    // camel Case is naming convention for parameters of methods

        //    var person = new Person();
        //    person.Name = "Oguz";
        //    person.Introduce("Esra");

        //    // There is another way to create instance.

        //    var p = Person2.Parse("Oguz");
        //    p.Introduce("Esra");


        //}
    }
}
