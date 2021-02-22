using System;

namespace IsPrime
{
    public class PrimeNums
    {

        static public bool IsPrime(int num) 
        {
            int maxRange = (int)Math.Sqrt(num);

            if (num <= 1) return false;

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }


        static public int PrimeSum(int num) 
        {
            int sum = 0;
            for (int i = 2; i <= num; i++)
            {
                sum += IsPrime(i) ? i : 0;
            }
            return sum;
          
        }
    }
}
