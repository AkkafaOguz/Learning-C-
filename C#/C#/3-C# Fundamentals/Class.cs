using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_._3_C__Fundamentals
{
    internal class Class
    {

        // Switch case are not working with double and float value types
        
        // Default parameters can be used for methods

        public static void DefaultParameter(int number, int number2 = 1)
        {
            Console.WriteLine("Normal parameter: {0} and Default parameter: {1}",number,number2);
        }

        // By using 'Named Arguments' order of arguments that send to the method are not important

        public static void NamedArguments(int number, int number2, string str)
        {
            Console.WriteLine("Order of parameters: {0},{1},{2}",number,number2,str);
        }

        //Expression Body syntax

        public static void ExpressionBodySyntax(int number) => 
            Console.WriteLine("Normal parameter: {0}", number);

        //static void Main(string[] args)
        //{
        //    DefaultParameter(0);
        //    NamedArguments(str: "Named Arguments", number2: 20, number:1);
        //}
    }
}
