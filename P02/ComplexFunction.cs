﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02
{
    class ComplexFunction : IFunction
    {
        public double F(double x)
        {
            return Math.Sqrt(x);
        }
    }
}
