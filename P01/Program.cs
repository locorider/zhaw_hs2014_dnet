using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                string sizeStr = args[0];
                int size = Int32.Parse(sizeStr);
                Sieve sieve = new Sieve();
                PrimeType[] types = sieve.Eratosthenes(size);
                PrintResult(types);
            }
            else
            {
                Console.Error.WriteLine("Please provide the size of the sieve");
            }
        }

        private static void PrintResult(PrimeType[] types)
        {
            for (int i = 0, l = types.Length; i < l; i++)
            {
                PrimeType type = types[i];
                int num = i + 1;
                if (0 < i && i % 10 == 0) {
                    Console.Write("\r\n");
                }
                if (PrimeType.NotPrim == type)
                {
                    Console.Write("_ ");
                }
                else
                {
                    Console.Write(num.ToString() + " ");
                }
            }
        }
    }
}
