using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    internal class PrimitiveTypesAndExpressions
    {
        

        static void Main(string[] args)
        {
            //Variable: a name given to a storage location in memory
            //Constant: an immutable value

            //Scope: Where a variable/constant has meaning and accessible

            /*
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;  //explicitly tell the C# compiler threat this real number as float.
            char character = 'A';
            string firstName = "Oguz";
            bool isWorking = false;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            */

            // cw + TAB -> shortcut of Console.WriteLine()

            /*
            Instead of explicitly specify data type, 'var' can be used and let the C# compiler detect data type of variables

            var number2 = 2;
            var count2 = 10;
            var totalPrice2 = 20.95f;
            var character2 = 'A';
            var firstName2 = "Oguz";
            var isWorking2 = false;
            */


            //Format String
            //Console.WriteLine("{0} {1}", byte.MaxValue, byte.MinValue);


            //const float Pi = 3.14f; //can not be reassigned because it's a constant value.

            /*
            Type Conversion

            Implicit Type Conversion: Small data types could be converted bigger data types automatically.
            byte b = 1;
            int i = b;

            Explicit Type Conversion: Big data types could not be converted smaller data types automatically. You should explicitly tell the compiler.
            int i = 1;
            byte b = (byte) i;

            Non-compatible Types: Different types of data.
            string s = "1";
            int i = (int) s; won't compile!

            int i = Convert.ToInt32(s);
            int i = int.Parse(s);
            */

            /*
            Operators
             
             -Arithmetic Operators
             -Comparison Operators
             -Assignment Operators
             -Logical Operators
             -Bitwise Operators
             */


        }
    }
}
