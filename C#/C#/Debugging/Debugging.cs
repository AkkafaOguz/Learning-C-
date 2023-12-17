using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.Debugging
{
    internal class Debugging
    { 
        // You can put break point by pressing 'F9'
        // 'F10' -> Step over (one-line execution)
        // 'F11' -> Step into
        // Watch Window: DEBUG -> Windows ->  Watch -> Watch1
        // 'Shift+F11' -> Step Out
        // 'Shift+F5' -> Stop debug mode
        // 'F5 after starting debug mode' -> continue until the next break point

        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
        }

        // Defensive Programming -> To check the input first before doing any processing
        // Call Stack -> Shows the order of methods that we've called from the moment the application run up to where you're now
        // Autos and Locals Windows
    }
}
