using System;

namespace problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("largest prime factor: " + GetPrimeFactor());
        }

        public static bool IsPrime(long num)
        {
            for(long i = 2; i < num; i++)
            {
                if(num % i == 0)
                    return false;
            }
            return true;
        }

        public static long GetPrimeFactor()
        {
            long num = 600851475143; //600851475143;
            long largest = 0;
            for(long i = num; i > 1; i--)
            {
                if(num % i == 0)
                {
                    if(IsPrime(i))
                    {
                        largest = i;
                        break;
                    }
                } 
            }
            return largest;
        }
    }
}
