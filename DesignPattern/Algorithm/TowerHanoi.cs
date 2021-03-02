using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Algorithm
{
    /// <summary>
    /// 汉诺塔
    /// </summary>
    public class TowerHanoi
    {
        /// <summary>
        /// 汉诺塔
        /// </summary>
        /// <param name="n"></param>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <param name="p3"></param>
        static void GetTowerHanoi(int n, string p1, string p2, string p3)
        {
            if (n == 1)
            {
                //Move
                Console.WriteLine($"第{n}个盘子从{p1}移动到{p3}");
            }
            else
            {
                GetTowerHanoi(n - 1, p1, p3, p2);
                //Move
                Console.WriteLine($"第{n}个盘子从{p1}移动到{p3}");
                GetTowerHanoi(n - 1, p2, p1, p3);
            }


        }
    }
}
