using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorAmplifierCalculator.SI
{
    internal class SIUnitConverter
    {
        private Dictionary<string, double> si= new Dictionary<string, double>();
        public SIUnitConverter() {
            si.Add("k", 1000);
            si.Add("-", 1);
            si.Add("m", 0.001);
            si.Add("u", 0.000001);
            si.Add("n", 0.000000001);
            si.Add("p", 0.000000000001);

        }
        public Dictionary<string, double> GetSIList() {
            return this.si;
        }
        public string ToSI(double d, string format = null)
        {
            char[] incPrefixes = new[] { 'k', 'M', 'G', 'T', 'P', 'E', 'Z', 'Y' };
            char[] decPrefixes = new[] { 'm', 'u', 'n', 'p', 'f', 'a', 'z', 'y' };

            int degree = (int)Math.Floor(Math.Log10(Math.Abs(d)) / 3);
            double scaled = d * Math.Pow(1000, -degree);

            char? prefix = null;
            switch (Math.Sign(degree))
            {
                case 1: prefix = incPrefixes[degree - 1]; break;
                case -1: prefix = decPrefixes[-degree - 1]; break;
            }

            return scaled.ToString(format) + prefix;
        }

    }
}
