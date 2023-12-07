using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odd_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            try
            {
                Console.WriteLine("please enter number");
                int v = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("odd numbers are:");
                for (int i = 1; i <= v; i++)

                    if (i % 2 != 0)


                        Console.WriteLine(i);

                    else
                        continue;

            }
            catch
            {
                for (int i = 1; i <= n; i++)

                    if (i % 2 != 0)


                        Console.WriteLine(i);

                    else
                        continue;
            }
        }
    }  
}
