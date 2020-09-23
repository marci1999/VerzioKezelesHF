using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repo
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam = 0;
            Console.WriteLine("hány szmotszeretne megadin?");
            int n = Convert.ToInt32(Console.ReadLine());
            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("adjon meg az {0} számot", i);
                szam = Convert.ToInt32(Console.ReadLine());
                if (szam < min)
                {
                    min = szam;
                }
                if (szam > max)
                {
                    max = szam;
                }

            }


            Console.WriteLine("a számok átlaga: "+(szam / 10));
        }
    }
}
