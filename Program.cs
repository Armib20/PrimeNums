using System;

namespace PrimeNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 2;
            int count = 0;
            while (count < 1000)
            {
                if (isPrime(num) == true)
                {
                    Console.WriteLine(num);
                    count += 1;
                }
                num += 1;
                
            }


        }

        public static bool isPrime(int num)
        {
            int check = 0;
            int div = 0;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    div += 1;
                }
                else
                {
                    {
                        check += 1;
                    }
                }
            }
            
            if (check == (num - 2))
            {
                return true;
            }
            else if (div > 0)
            {
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}