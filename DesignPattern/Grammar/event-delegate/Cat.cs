using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTest
{
    /* 
     * 使用
        Cat cat = new Cat();
        Mouse m = new Mouse(cat);
        People p = new People(cat);
        cat.Scream("喵");
     */
    public delegate void ScreamHandler(string msg);

    public class Cat
    {
        public event ScreamHandler OnScream;

        public ScreamHandler screamHandler;
        public void Scream(string msg)
        {
            Console.WriteLine("猫叫了一声");
            OnScream?.Invoke(msg);
            screamHandler?.Invoke(msg);
        }
    }

    public class Mouse
    {
        public Mouse(Cat c)
        {
            c.OnScream += (msg) =>
            {
                Console.WriteLine("事件----老鼠听到了:" + msg + ",老鼠跑了");
            };
            c.screamHandler += (msg) =>
            {
                Console.WriteLine("委托----老鼠听到了:" + msg + ",老鼠跑了");
            };
        }
    }

    public class People
    {
        public People(Cat c)
        {
            c.OnScream += (msg) =>
            {
                Console.WriteLine("事件----主人听到了:" + msg + ",主人醒来了");
            };
            c.screamHandler += (msg) =>
            {
                Console.WriteLine("委托----主人听到了:" + msg + ",主人醒来了");
            };
        }
    }

}
