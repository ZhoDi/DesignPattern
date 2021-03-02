using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Algorithm
{
    /// <summary>
    /// 二分法查找数据
    /// </summary>
    public class Dichotomy
    {
        /// <summary>
        /// 二分法查找数据
        /// </summary>
        /// <returns></returns>
        static int GetDichotomy(int[] numbers, int matchNumber, int begin, int end)
        {
            int indexCenter = (begin + end) / 2;
            if (begin > end)
            {
                return -1;
            }

            if (numbers[indexCenter] == matchNumber)
            {
                return indexCenter;
            }
            else if (numbers[indexCenter] > matchNumber)
            {
                return GetDichotomy(numbers, matchNumber, begin, indexCenter - 1);
            }
            else
            {
                return GetDichotomy(numbers, matchNumber, indexCenter + 1, end);
            }
        }
    }
}
