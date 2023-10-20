using MathNet.Numerics.Distributions;
using MathNet.Numerics.Random;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimUrbanV2
{
    class Math
    {
        public int[] DisTest() {
            //var b = Binomial.Sample(0.5,10000);
            //b = Poisson.Sample(3);
            //Console.WriteLine(b);
            //double[] samples = new double[100000];
            int n = 10;
            int[] b = new int[n];
            Poisson.Samples(b,3);
            return b;
        }

        public void RouletteSele<T>(ref Dictionary<T,double> DicIn,ref T result)
        {
            Random ran = new Random();
            double i = ran.NextDouble();
            double Probability_Total = 0;
            bool ifind = false;
            foreach (var item in DicIn)
            {
                Probability_Total = Probability_Total + item.Value;
                if (Probability_Total > i)
                {
                    result = item.Key;
                    ifind = true;
                    break;
                }
            }
            //If the input probability is wrong, the first one is output by default！！
            if (!ifind)
            {
                foreach (var item in DicIn)
                {
                   result = item.Key;
                   ifind = true;
                    break;
                }
                Console.WriteLine("-----Please check if the cumulative probability is 1-----");
            } 
        }

        public void RouletteSele<T>(ref List<double> DicIn, ref int result)
        {
            Random ran = new Random();
            double i = ran.NextDouble();
            double Probability_Total = 0;
            bool ifind = false;
            int ii = 0;
            foreach (var item in DicIn)
            {
                Probability_Total = Probability_Total + item;
                if (Probability_Total > i)
                {
                    result = ii;
                    ifind = true;
                    break;
                }
                ii++;
            }
            //If the input probability is wrong, the first one is output by default！！
            if (!ifind)
            {
                result = 0;
                Console.WriteLine("-----Please check if the cumulative probability is 1-----");
            }
        }


        public void Normal(ref List<double> listin)
        {
            double min = 99999;
            double max = 0;
            foreach (var item in listin)
            {
                if (item < min)
                {
                    min = item;
                }
                if (item > max)
                {
                    max = item;
                }
            }
            for (int i = 0; i < listin.Count; i++)
            {
                listin[i] = (listin[i] - min) / (max - min);
            }
        
        }

    }
}
