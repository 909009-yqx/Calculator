using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20210322计算器
{
    class Program
    {
        static void Main(string[] args)
        {
            Count c = new Count();
            
            while (true)
            {
                int x, y;
                char t;
                Console.WriteLine("==================================================");
                Console.WriteLine("输入两个整数：");
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
                c.Equals(x, y);
                Console.WriteLine("输入将要进行的操作：+,-,*,/,0");
                t = Convert.ToChar(Console.ReadLine());
                switch (t)
                {
                    case '0':
                        return;
                    case '+':
                        c.Add(x, y);
                        break;
                    case '-':
                        c.Sub(x, y);
                        break;
                    case '*':
                        c.Mul(x, y);
                        break;
                    case '/':
                        try
                        {
                            c.Div(x, y);
                        }
                        catch
                        {
                            Console.WriteLine("分母不能为零");
                        }
                        finally
                        {
                            Console.WriteLine("结束");
                        }
                        break;
                    default:
                        Console.WriteLine("无此项操作！");
                        break;

                }
            }
            
        }
    }
}
