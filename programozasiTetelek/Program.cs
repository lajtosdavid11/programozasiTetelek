using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programozasiTetelek
{
    class Program
    {

        static int[] tomb = new int[10] { 12, 7, 2, 4, 45, 99, 1, 8, 95, 50};

        static void kiiras()
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i]+ ",");
            }
        }
        static void Main(string[] args)
        {
            kiiras();

            Console.ReadKey();
        }
    }
}
