using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_RLC
{
    public static class Operations
    {
        public static double Derivative(double current, double next)
        {
            double d;
            d = next - current;
            return d;
        }

        public static double Integral(double current, double next, int sample_freq)
        {
            double dSamplFreq = sample_freq;
            double a_square = current * (1 / dSamplFreq);
            double triangle_surface = ((next - current) * (1 / dSamplFreq)/ 2);
            double integration = a_square + triangle_surface;
            return integration;

        }
        
    }
}
