using System;

namespace problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
        public static long problem2()
        {
            long sum  = 0;
            long term1 = 1;
            long term2 = 0;
            long next = 1;
            while(next < 4000000)
            {
                next = term1 + term2;
                term2 = term1;
                term1 = next;
                if(next % 2  == 0)
                    sum += next;
                Console.WriteLine(next);
            }
            return sum;
        }

    }
}
