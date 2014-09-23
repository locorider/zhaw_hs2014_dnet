using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02
{
    class Integrator
    {
        public double Integrate(IFunction function, long steps, double startX, double endX)
        {
            double result = 0.0, d = (endX - startX) / ((double)steps);
            long step = 0;
            for (double x = startX; x <= endX; x += d)
            {
                double y = function.F(x);
                if (0 < step && step < steps)
                {
                    double tmpResult = d * y;
                    result += tmpResult;
                }
                else
                {
                    double tmpResult = d * y * 0.5;
                    result += tmpResult;
                }
                step++;
            }
            return result;
        }

        public double Integrate(IFunction function, double endX)
        {
            double result = Integrate(function, 100, 0.0, endX);
            return result;
        }

        public double Integrate(IFunction function, long steps, double endX)
        {
            double result = Integrate(function, steps, 0.0, endX);
            return result;
        }
    }
}
