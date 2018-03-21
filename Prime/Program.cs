using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 101; i <= 200; i++)
            {
                if (PrimeAll(i))
                {
                    Console.WriteLine("質數" +i);
                }
            }
        }
        static bool PrimeAll(int item)
        {
            for (int i = 2; i < item; i++)
            {
                if (item % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
