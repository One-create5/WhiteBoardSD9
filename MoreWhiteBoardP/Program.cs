using System;

namespace MoreWhiteBoardP
{
    class Program
    {
        static Random rand = new Random(123);
        static void Main(string[] args)
        {

            int number = 10;

            int sum = 0;

            for (int i = 0; i < number; i++)
            {
                sum += Results();
            }

            Console.WriteLine($"Sum: {sum}");
        }

        static public int Results() 
        {
            int low = 1;
            int high = 100;

            return rand.Next(low, high + 1); 
        }
        
    }
}
