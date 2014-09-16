using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01
{
    class Sieve
    {
        public PrimeType[] Eratosthenes(int size)
        {
            PrimeType[] result = new PrimeType[size];
            for (int i = 1; i < size; i++)
            {
                int number = i + 1;
                if (number * number <= size)
                {
                    for (int j = i + 1; j < size; j++)
                    {
                        int nextNumber = j + 1;
                        if (nextNumber % number == 0)
                        {
                            result[j] = PrimeType.NotPrim;
                        }
                    }
                }
                
            }
            return result;
        }

        public List<int> EratosthenesList(int size)
        {
            List<int> result = new List<int>();
            PrimeType[] types = Eratosthenes(size);
            for (int i = 0, l = types.Length; i < l; i++)
            {
                PrimeType type = types[i];
                if (PrimeType.Prim == type)
                {
                    result.Add(i + 1);
                }
            }
            return result;
        }

        public int[] EratosthenesArray(int size)
        {
            List<int> list = EratosthenesList(size);
            int[] result = list.ToArray();
            return result;
        }

        public Dictionary<int, int> EratosthenesDict(int size)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            List<int> list = EratosthenesList(size);
            int idx = 0;
            foreach (int number in list)
            {
                result.Add(idx++, number);
            }
            return result;
        }
    }
}
