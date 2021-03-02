using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Algorithm
{
    /// <summary>
    /// 斐波那契数列
    /// </summary>
    public class FibonacciSequence
    {
        /// <summary>
        /// 斐波那契数列
        /// </summary>
        /// <param name="n">位数</param>
        /// <returns></returns>
        static int GetFibonacciSequence(int n)
        {
            if (n == 1)
                return 0;
            else if (n == 2)
                return 1;
            else
                return GetFibonacciSequence(n - 1) + GetFibonacciSequence(n - 2);
        }

    }
}
