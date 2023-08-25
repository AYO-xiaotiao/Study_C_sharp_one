using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_4_怎么得到用户输入
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = Console.ReadLine();//等待用户输入，输入后返回的数据类型是字符串类型，使用字符串类型进行接收
            //Console.WriteLine(str + "-");

            //将输入返回的数字字符串类型转换为int类型
            //int a = Convert.ToInt32(Console.ReadLine());//如果输入的不是数字将会转换错误

            //计算输入的两个整数
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(b + c);

            //计算两个数的平均数
            //double d = (double)(b + c) / 2;
            //Console.WriteLine(d);

            //将a元钱分给b个人，每个人可以分多少？
            //Console.WriteLine(b / c);

            //Console.ReadKey();

            //交换两个变量的值
            //方法一：使用临时变量
            int a = 5;
            int b = 6;
            int temp = 0;
            temp = a;
            a = b;
            b = temp;
            //方法二：
            a = a + b;
            b = a - b;
            a = a - b;

        }
    }
}
