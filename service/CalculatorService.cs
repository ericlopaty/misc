﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Microsoft.ServiceModel.Samples
{
    public class CalculatorService: ICalculator
    {
        public double Add(double n1, double n2)
        {
            double result = n1 + n2;
            Console.WriteLine("Received Add({0}, {1})", n1, n2);
            Console.WriteLine("Returned: {0}", result);
            return result;
        }

        public double Subtract(double n1, double n2)
        {
            double result = n1 - n2;
            Console.WriteLine("Received Subtract({0}, {1})", n1, n2);
            Console.WriteLine("Returned: {0}", result);
            return result;
        }

        public double Multiply(double n1, double n2)
        {
            double result = n1 * n2;
            Console.WriteLine("Received Multiply({0}, {1})", n1, n2);
            Console.WriteLine("Returned: {0}", result);
            return result;
        }

        public double Divide(double n1, double n2)
        {
            double result = n1 / n2;
            Console.WriteLine("Received Divide({0}, {1})", n1, n2);
            Console.WriteLine("Returned: {0}", result);
            return result;
        }
    }
}
