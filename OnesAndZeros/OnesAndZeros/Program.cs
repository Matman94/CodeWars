using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnesAndZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arrayTests = { 0, 0, 1, 0, 1, 0, 1, 1 };
            //int result = Kata.binaryArrayToNumber(arrayTests);

            int[] arrayTests = { 1, 1, 1, 0, 1, 1, 1, 1 };
            int result = Kata.binaryArrayToNumber(arrayTests);

            Console.WriteLine("tablica - liczba dwójkowo: {0}", string.Join(",", arrayTests));
            Console.WriteLine("================================================================");
            Console.WriteLine("================================================================");
            Console.WriteLine("Wynik: {0}", result);
            Console.WriteLine("================================================================");
            Console.WriteLine("================================================================");
            Console.ReadLine();
        }
    }
}
