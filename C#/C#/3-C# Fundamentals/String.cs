using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_._3_C__Fundamentals
{
    internal class String
    {
        //static void Main(string[] args)
        //{
        //    var name = "Oguz";
        //    var age = 28;

        //    // String Format

        //    var sentence = string.Format("Hi {0}, you're {1} years old.", name, age);
        //    Console.WriteLine(sentence);

        //    // String Interpolation

        //    var sentence2 = $"Hi {name}, you're {age} years old.";
        //    Console.WriteLine(sentence2);

        //    // Verbatim Strings

        //    var path = "C:\\Documents\\readme.txt";
        //    var path2 = @"C\Documents\readme.txt";  // <- Verbatim strings

        //    // -> \" for double quote

        //    var example = "This is \"the best\" part";
        //    Console.WriteLine(example);

        //    // Try Parse

        //    var tryPar = "x";
        //    int tryParNumber;
        //    Console.WriteLine(int.TryParse(tryPar, out tryParNumber));

        //    // Method parameters (ref)

        //    var first = 2;
        //    var second = 3;
        //    var third = 4; // <- must be initialized 
        //    checkParametersRef(first,second,ref third);
        //    Console.WriteLine("first => " + first);
        //    Console.WriteLine("second => " + second);
        //    Console.WriteLine("third => " + third);

        //    // Method parameters (out)

        //    int outKey;
        //    checkParametersOut(first,out outKey);
        //    Console.WriteLine("outKey =>" + outKey);

        //    // Null

        //    // -> ?? it's for using default value if value is null
        //    // e.g -> int a = value ?? 2;
        //    nullCheck(1, 2);

        //}

        // Method parameters (ref)
        private static void checkParametersRef(int a, int b)
        {
            a++;
            b++;
        }

        private static void checkParametersRef(int a, int b, ref int c)
        {
            a++;
            b++;
            c++;
        }

        // Method parameters (out)
        private static void checkParametersOut(int a, out int b)
        {
            b = 0;
            a++;
            b++;
        }

        private static void nullCheck(int a, int? b)
        {
            int c = a;
            int d = b ?? 2;
        }

    }
}
