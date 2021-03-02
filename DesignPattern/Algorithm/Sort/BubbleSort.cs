using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Algorithm.Sort
{
    /// <summary>
    /// 冒泡排序
    /// </summary>
    public class BubbleSort
    {
        /// <summary>
        /// 冒泡排序
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        static int[] GetBubbleSort(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length - i - 1; j++)
                {
                    if (nums[j] < nums[j + 1])
                    {
                        var oldj = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = oldj;
                    }
                }
            }
            return nums;
        }
    }
}
