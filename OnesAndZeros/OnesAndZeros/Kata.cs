using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnesAndZeros
{
    public class Kata
    {
        public static int binaryArrayToNumber(int [] BinaryArray)
        {
            int sum = 0;
            int n = 0; // which power - która potęga

            int countIteration = 0;

            //code here
            for (int i=BinaryArray.Length-1; i >= 0; i--)
            {
                Console.WriteLine("Jest to {0} iteracja pętli for", countIteration);

                if (BinaryArray[i] == 1)
                {
                    int multiple = 1;
                    
                    if (n > 0)
                    {
                        for (int j = 0; j <= n-1; j++)
                        {
                           
                            multiple *= 2;
                            
                        }
                    }
                    
                    sum += multiple;

                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Aktualna potęga: {0}", n);
                    Console.WriteLine("Aktualna wartość mnożenia: {0}", multiple);
                    Console.WriteLine("Aktualna suma: {0}", sum);
                    Console.WriteLine("----------------------------------------");


                    n++;
                }
                else
                {
                    n++;
                }

                countIteration++;
            }

            return sum;
        }
    }
}
