using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringsdetails
{
    class Program
    {
        static void Main(string[] args)
        {
            // \ = escape sequence
            // @ = "puts everything within the quotes as not escape sequences, ie that's how you'd write file paths"
            //string name = "Clare";
            //string quote = "This is a \"quote\" . \n is a new line, \n \t this is a tab on a new line.";
            //string fileName = @"C:\Users\Clare";

            //bool trueOrFalse = name.Contains("r"); // whether the string 'name' has 'r' in it or not

            //int length = name.Length; // prints char length of name

            String name = "Jesse";
            name = "Clare";

            name = name.ToUpper(); // converts to upper case
            //name = name.ToLower(); //converts to lower case

            //Console.WriteLine(length);


            //StringBuilder sb = new StringBuilder();

            //sb.Append("My name is Clare");

            Console.ReadLine();
        }
    }
}
