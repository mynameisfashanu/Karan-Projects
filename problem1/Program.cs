using System;

namespace problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int problem1(int count)
        {
            int sum = 0;
            for(int i = 1; i < count; i++)
            {
                if(i % 5 == 0 || i % 3 == 0)
                    sum += i;
            }
            return sum;
        }

    }
}
