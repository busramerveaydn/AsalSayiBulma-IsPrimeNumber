using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalSayiBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            if (IsPrimeNumber(7))
            {
                Console.WriteLine("This is a Prime Number");
            }
            else
            {
                Console.WriteLine("This is not a Prime Number");
            }
            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if (number % 2 == 0)
                {
                    result = false;
                    i = number;//döngüyü sonlandırmak için
                }
            }
            return result;
        }
    }
}
