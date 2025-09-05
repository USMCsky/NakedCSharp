using System;
namespace Strings
{
    public class StringsTest
    {
        static public void Main()
        {
            //ascii table
            char myChar = 'A';
            int asciiA = (int)myChar; //casting char to int to get the
            Console.WriteLine("The ascii value of {0} is {1}\n", myChar, asciiA);

            int charNumber = 'z';
            Console.WriteLine("The ascii value of {0} \n",  charNumber);

            string s = "The Quick Fox"; 
            s = s + " Jumps Over The Lazy Dog"; //string concatenation

            Console.WriteLine("{0,-10} {1,10}","Left", "Right");

        }
    }
}
