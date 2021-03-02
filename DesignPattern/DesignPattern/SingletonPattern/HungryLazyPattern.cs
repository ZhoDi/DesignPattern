using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DesignPattern.SingletonPattern
{
    /// <summary>
    /// 延迟加载模式 也采用静态变量方式,但是加入Lazy关键字,在第一次调用的时候创建
    /// </summary>
    public class HungryLazyPattern
    {
        private HungryLazyPattern() { }

        public static readonly Lazy<HungryLazyPattern> _HungryLazyPattern = new Lazy<HungryLazyPattern>(() => new HungryLazyPattern());

        public static HungryLazyPattern Instance
        {
            get
            {
                return _HungryLazyPattern.Value;
            }
        }
    }
}
