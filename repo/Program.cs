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
            int szam = 0
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("adjon meg az {0} számot", i);
                szam = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("a számok átlaga: "+(szam / 10));
            }
        }
    }
}
