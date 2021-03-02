using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DesignPattern.SingletonPattern
{
    /// <summary>
    /// 双检查加锁方式,也是延迟加载的一种
    /// </summary>
    public class DCL
    {
        //可用volatile修饰,防止指令重排
        private static DCL _DCL;
        // 定义一个锁，防止多线程
        private static readonly object locker = new object();
        private DCL() { }
        public static DCL Instance
        {
            get
            {
                //第一次创建,多个线程可同时进入,排除掉后续进入不需要加锁的情况
                if (_DCL == null)
                {
                    //进入后加锁,一个一个进入
                    lock (locker)
                    {
                        if (_DCL == null)
                        {
                            _DCL = new DCL();
                        }
                    }
                }
                return _DCL;
            }
        }
    }
}
