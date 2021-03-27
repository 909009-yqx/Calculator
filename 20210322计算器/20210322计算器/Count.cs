using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20210322计算器
{
    class Count
    {
        public void Add(int x, int y)
        {
            Console.WriteLine("相加为：{0}", x + y);
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine("相减为：{0}", x - y);
        }
        public void Mul(int x, int y)
        {
            Console.WriteLine("相乘为：{0}", x * y);
        }
        public void Div(int x, int y)
        {
            Console.WriteLine("相除为：{0}", x / y);
        }
        public bool Equals(int x, int y)
        {
            if (x == y)
            {
                Console.WriteLine("两整数相等");
                return true;
            }
            else
            {
                Console.WriteLine("两整数不等");
                return false;
            }
        }
    }
}
