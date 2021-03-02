using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DesignPattern.SingletonPattern
{
    /// <summary>
    /// 懒汉模式 使用静态构造,第一次使用的时候创建
    /// </summary>
    public class LazyPattern
    {
        private LazyPattern() { }

        static LazyPattern()
        {
            Instance = new LazyPattern();
        }

        public static LazyPattern Instance { get; private set; }


    }
}
