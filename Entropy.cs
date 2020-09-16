using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmLib
{
    /*
     * xuml 20190923 熵公式的实现
     */
    public class Entropy
    {
        public static double CalEntropy(double[] percents, double blowNum)
        {
            if (percents.Length < 1)
            {
                throw new Exception("");
            }

            double result = 0;
            for (int i = 0; i < percents.Length; i++)
            {
                result += percents[i] * Math.Log(percents[i], blowNum);
            }
            return 0 - result;
        }
        
    }
}
