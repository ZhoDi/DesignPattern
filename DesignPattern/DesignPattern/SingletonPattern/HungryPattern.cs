using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DesignPattern.SingletonPattern
{
    /// <summary>
    /// 饿汉模式 使用静态变量,CLR初始化就创建
    /// </summary>
    public class HungryPattern
    {
        private HungryPattern(){ }

        public static HungryPattern Instance { get; } = new HungryPattern();

    }
}
