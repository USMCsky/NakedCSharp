using System;
namespace Variables
{
    public class VariableTest
    {
        static public void Main()
        {
            int number = 5; //4 bytes of memory (32 bits)
            float aVal = 7.62f; //without the f, it is considered a double by default
            double myDbl = 3.14159; //more precision than float and takes more memory (8 bytes instead of 4 bytes)
            Console.WriteLine("My values are:\n {0} integer \n {1} float \n {2} double \n", number, aVal, myDbl);

            char myChar = 'A'; //single quotes for char, double quotes for string
            string myString = "Hello World"; //string is a sequence of characters
            Console.WriteLine("My values are:\n {0} char \n {1} string \n", myChar, myString);

            bool myBool = true; //true or false
            Console.WriteLine("My value is:\n {0} boolean \n", myBool);

            const double pi = 3.14159; //constant value, cannot be changed
            Console.WriteLine("The value of pi is:\n {0} \n", pi);

            //ascii table
            int asciiA = (int)myChar; //casting char to int to get the
            Console.WriteLine("The ascii value of {0} is {1}\n", myChar, asciiA);

            int charNumber = 'B';
            char myCharacter = (char) 66;
            Console.WriteLine("The ascii value of {0} is {1}\n", myCharacter, charNumber);

            string s = "The Quick Fox"; //empty string
            s = s + " Jumps Over The Lazy Dog"; //string concatenation

            Console.WriteLine("The length of the string \"{0}\" is {1}\n", s, s.Length);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            Console.WriteLine(
                "This is a test to see if the console window stays open after pressing a key. If you see this message, it worked!"
            );
        }
    }
}
