using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chick
{
    class Program
    {
        static void Main(string[] args)
        {
            int X=0;
            int Y=0;
            int Z=0;
            for (int i = 0; i < 900/29;i++)
            {
               if((900-59*i)%29==0)
                {
                    X = i;
                    Y = (900 - 54 * i) / 29;
                    Z = 100 - X - Y;
                    break;
                }
                 
            }
            Console.WriteLine("公雞"+X.ToString()+"母雞:"+Y.ToString()+"小雞:"+Z.ToString());
            Console.ReadLine();

        }
    }
}
