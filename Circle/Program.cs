using System;

namespace Circle
{
    class Program
    {
        static double AreaOfCircle(int radius) => Math.PI * radius * radius;
        
        static void Main(string[] args)
        {
            Console.WriteLine("Cicle.Program.Mian()");

            Console.WriteLine(AreaOfCircle(10));
        }
    }
}
