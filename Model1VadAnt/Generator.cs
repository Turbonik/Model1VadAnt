using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model1VadAnt
{
    public class Generator
    {
        private long _a;

        public long A
        {
            get { return _a; }
            private set
            {
                if (!IsPositive(value))
                    throw new Exception($"Value a = {value} is not positive");

                _a = value;
            }
        }

        private long _r0;

        public long R0
        {
            get { return _r0; }
            private set
            {
                if (!IsPositive(value))
                    throw new Exception($"Value r0 = {value} is not positive");

                _r0 = value;
                RNew = value;
            }
        }

        private long _m;

        public long M
        {
            get { return _m; }
            private set
            {
                if (!IsPositive(value))
                    throw new Exception($"Value m = {value} is not positive");

                if (value <= A)
                    throw new ArgumentException($"Value m = {value} must be greater than a = {A}", "m");

                _m = value;
            }
        }

        public long RPrev { get; private set; }
        public long RNew { get; private set; }

        public Generator(long a, long r0, long m)
        {
            A = a;
            R0 = r0;
            M = m;
        }

        public double GetNext()
        {
            RPrev = RNew;
            RNew = (A * RPrev) % M;

            return RNew / (float)M;
        }

        private static bool IsPositive(long number) => number > 0;
    }
}