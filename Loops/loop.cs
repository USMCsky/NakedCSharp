using System;

namespace Loops
{
    public class Loops
    {
        static public void Main(string[] args)
        {
            int total = 0;
            int i = 2;
            while (i < 9)
            {
                total += 2; 
                i += 1; 
            }
            Console.WriteLine("The total is: {0}", total);

            int totalDo = 10;
            int x = 2;
            do
            {
                totalDo += 3; 
                x += 1; 
            } while (x < 3);
            Console.WriteLine("The total using do-while is: {0}", totalDo);
            

            for (int h = 0; h < 2; h++)
            {
                for(int j = 1; j < 3; j++)
                {
                    Console.WriteLine(h * j);
                }
            }

            for(int z = 0; z < 10; z++)
            {
                for(int p = 1; p < 2; p++)
                    {
                    Console.WriteLine(z + p);
                }
            }

            int t = 0;
            while (t < 5)
            {
                Console.WriteLine("Hi");
                t++;
            }

            int c = 10;
            do
            {
                Console.WriteLine(c);
                c-=3;
            }
            while (c > -4);

        }
    }
}
