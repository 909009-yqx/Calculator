using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20210322简单计算器Github
{
    class Count2:Count,IStringCount
    {
        public void Sadd(string a, string b)
        {
            StringBuilder s = new StringBuilder();
            s.Append(a);
            s.Append(b);
            Console.WriteLine("字符串连接为：{0}",s);
        }
        public void Ssub(string a, string b)
        {
            string u = a.Replace(b, "");
            Console.WriteLine("字符串去除为：{0}", u);
        }
    }
}
