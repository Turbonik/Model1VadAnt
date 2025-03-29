using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model1VadAnt
{
    public class SeriesMethod
    {
      
        private static string SeriesChecker(double[] nums)
        {
            double border = 0.5;
            string types = "";
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < border)
                {
                    types += "a";
                }
                else
                {
                    types += "b";


                }
            }
            return types;
        }

        public static string ScrutiniseSequence(double[] nums, int N)
        {
            string types = SeriesChecker(nums);

            List<int> seriesA = new List<int>();
            List<int> seriesB = new List<int>();
            char currentType = types[0];
            int currentLength = 1;

            for (int i = 1; i < types.Length; i++)
            {
                if (types[i] == currentType)
                {
                    currentLength++;
                }
                else
                {
                    if (currentType == 'a')
                    {
                        seriesA.Add(currentLength);
                    }
                    else
                    {
                        seriesB.Add(currentLength);
                    }
                    currentType = types[i];
                    currentLength = 1;
                }
            }

            if (currentType == 'a')
            {
                seriesA.Add(currentLength);
            }
            else
            {
                seriesB.Add(currentLength);
            }

            int Ra = seriesA.Count;
            int Rb = seriesB.Count;

        
            double maxA = (seriesA.Count > 0) ? seriesA.Max() : 0;
            double maxB = (seriesB.Count > 0) ? seriesB.Max() : 0;

            double beta = 0.95;
            double Ra_theoretical = 0.25 * (N - 1.63 * Math.Sqrt(N + 1));
            double Rb_theoretical = Ra_theoretical;
            double nmax_theoretical = Math.Log(N / Math.Log(1 / beta)) / Math.Log(2) - 1;

            StringBuilder sb = new StringBuilder();
            sb.Append($"Ra экспериментальное = {Ra} \n Rb экспериментальное = {Rb}");
            sb.Append($"\n nmaxA экспериментальное  = {maxA} \n nmaxB экспериментальное  = {maxB} \n");
            sb.Append($"Ra, Rb теоретическое {Math.Ceiling(Ra_theoretical)} \n ");
            sb.Append($"nmaxA, nmaxB теоретическое {nmax_theoretical}");


            if ((Ra > Ra_theoretical) && (Rb > Rb_theoretical) && (nmax_theoretical > maxA) && (nmax_theoretical > maxB))
            {
                sb.Append($"\n\n гипотеза о “случайности” не опровергается опытными данными");
            }
            else
            {
                sb.Append($"\n\n гипотеза о “случайности”  опровергается опытными данными");
            }

            return sb.ToString();

           
        }
    }
}
