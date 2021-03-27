using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20210322简单计算器Github
{
    class Program
    {
        static void Main(string[] args)
        {
            Count c = new Count();
            Count2 c2 = new Count2();
            int x, y,n;
            char t;
            string a, b;
            while (true)
            { 
                Console.WriteLine("==================================================");
                Console.WriteLine("输入将要进行的操作：+,-,*,/，0");
                t = Convert.ToChar(Console.ReadLine());
                switch (t)
                {
                    case '0':
                        return;
                    case '+':
                        {
                            Console.WriteLine("将要1.整数相加 或 2.字符串连接");
                            n = Convert.ToInt32(Console.ReadLine());  
                            if (n == 1)
                            {
                                Console.WriteLine("输入两数：");
                                x = Convert.ToInt32(Console.ReadLine());
                                y = Convert.ToInt32(Console.ReadLine());
                                c.Equals(x, y);
                                c.Add(x, y);
                            }
                            if (n == 2)
                            {
                                Console.WriteLine("输入将要连接的字符串：");
                                a = Convert.ToString(Console.ReadLine());
                                b = Convert.ToString(Console.ReadLine());
                                c2.Sadd(a, b);
                            }
                            break;
                        }  
                    case '-':
                        {
                            Console.WriteLine("将要1.整数相减 或 2.字符串去除");
                            n = Convert.ToInt32(Console.ReadLine());
                            if (n == 1)
                            {
                                Console.WriteLine("输入两数：");
                                x = Convert.ToInt32(Console.ReadLine());
                                y = Convert.ToInt32(Console.ReadLine());
                                c.Equals(x, y);
                                c.Sub(x, y);
                            }
                            if (n == 2)
                            {
                                Console.WriteLine("输入将要减法操作的字符串：");
                                a = Convert.ToString(Console.ReadLine());
                                b = Convert.ToString(Console.ReadLine());
                                c2.Ssub(a, b);
                            }
                            break;
                        }  
                    case '*':
                        Console.WriteLine("输入两数：");
                        x = Convert.ToInt32(Console.ReadLine());
                        y = Convert.ToInt32(Console.ReadLine());
                        c.Mul(x, y);
                        break;
                    case '/':
                        Console.WriteLine("输入两数：");
                        x = Convert.ToInt32(Console.ReadLine());
                        y = Convert.ToInt32(Console.ReadLine());
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
