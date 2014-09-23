using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02
{
    class Program
    {
        static void Main(string[] args)
        {
            Integrator integrator = new Integrator();
            double result = integrator.Integrate(new SimpleFunction(), 1000000, 10000);
            Console.WriteLine(result);

            result = integrator.Integrate(new ComplexFunction(), 1000000, 10000);
            Console.WriteLine(result);
        }
    }
}
