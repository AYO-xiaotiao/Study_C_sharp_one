using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_7_基本数据类型
{
    class Program
    {
        static void Main(string[] args)
        {
            //整型sbyte byte short ushort int uint long ulong
            //一般使用int，4个字节
            //byte:0--255 int long
            //sbyte:-128--127
            //无符号：byte ushort uint ulong
            //赋值，把小的放入大的没问题，但是把大的放入小的，确定可以放下的情况下需要强转，放不下的话会丢失放入不了的数据

            //浮点型
            //float，4个字节 double，8个字节,金钱相关的计算：decimal
            float f = 4.5f;//使用float时需要在后面加f
            f = 2121313141491;
            Console.WriteLine(f);//不会精准输出，保留6位小数
            Console.ReadKey();

            //字符类型
            //char string

            //类型的显式转换和隐式转换
            //显式转换又称为强转
            //转换时只能转换同一类型

            //字符串转换成数字
            int i = Convert.ToInt32("234");
            double j = Convert.ToDouble("4.65");

            //数字转换成字符串
            string str = 123 + "";
            string str1 = Convert.ToString(123);



        }
    }
}
