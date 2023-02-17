using System;

namespace Primes
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num;
            string response;
            Console.WriteLine("Enter a number: ");
            response = Console.ReadLine();
            num = int.Parse(response);
            if (IsPrime(num))
            {
                Console.WriteLine(num + ": is prime");
            }
            else
            {
                Console.WriteLine(num + ": is not prime");
            }
        }
        public static bool IsPrime(int number)
        {
            if (number < 2) return false;  // 0 y 1 no son primos

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

