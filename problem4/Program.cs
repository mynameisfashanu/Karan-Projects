using System;

namespace problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Largest Palindrome: " + LargestPalindrome());
        }

        public static bool IsPalindrom(int num)
        {
            string strnum = num.ToString();
            string palindrome = "";
            for(int i = strnum.Length - 1; i >= 0; i--)
            {
                palindrome += strnum[i];
            }
            if(palindrome == strnum)
                return true;
            return false;
        }

        /*
            start from largest possible 3 digit multiple, 999 * 999 
            subtract by 1, check if value is a palindrome.
            if so start from 999 -> 100 , check if it has a 3 digit factor,
            if so, divide the check if the result is also a 3 digit value,
            if so  return the number.
         */
         public static int LargestPalindrome()
         {
             for(int i = 998001; i >= 10000; i--)
             {
                 if(IsPalindrom(i))
                 {
                     for(int j = 999; j >= 100; j--)
                     {
                         if(i % j == 0)
                         {
                             int value = (i / j);
                             if(value.ToString().Length == 3)
                                return i;
                         }
                     }
                 }
             }
             return 0; 
         }
    }
}
