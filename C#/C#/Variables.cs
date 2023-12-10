using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    internal class Variables
    {
        

        static void Main(string[] args)
        {
            //Variable: a name given to a storage location in memory
            //Constant: an immutable value

            //Scope: Where a variable/constant has meaning and accessible

            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;  //explicitly tell the C# complier threat this real number as float.
            char character = 'A';
            string firstName = "Oguz";
            bool isWorking = false;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            // cw + TAB -> shortcut of Console.WriteLine()

            //Instead of expicitly specify data type, 'var' can bu used and let the C# compiler detect data type of variables

            var number2 = 2;
            var count2 = 10;
            var totalPrice2 = 20.95f;
            var character2 = 'A';
            var firstName2 = "Oguz";
            var isWorking2 = false;


            //Format String
            Console.WriteLine("{0} {1}", byte.MaxValue, byte.MinValue);


            const float Pi = 3.14f; //can not be reassigned because it's a constant value.


        } 
    }
}
