using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model1VadAnt
{
    public class Distribution
    {

        private static double _seed = 0.12345;
        private const double multiplier = 1111;        

        public Distribution(double seed)
        {
            _seed = seed;
        }

        public double NextDouble()
        {
            _seed = _seed * multiplier - Math.Truncate(_seed * multiplier);   
            return _seed;
        }
        public double[] GenerateRandomNumbers(int count)
        {
            double[] randomNumbers = new double[count];
            for (int i = 0; i < count; i++)
            {
                randomNumbers[i] = NextDouble();
            }
            return randomNumbers;
        }

    }
}
