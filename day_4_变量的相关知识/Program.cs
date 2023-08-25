using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_4_变量的相关知识
{
    class Program
    {
        static void Main(string[] args)
        {
            //数据：整数 浮点数 字符 字符串
            //数据储存在内存中
            //数据储存的容器-变量

            //创建变量
            int age;//变量类型+变量名，变量不能重名
            age = 10;//变量的赋值，将右边的值赋给左边
            //double age1 = 12;
            //char age2;

            //变量名的命名规则：
            //由大小字母，数字，下划线组成，数字不能做开头
            //不能用关键字
            //变量名的命名规范：
            //驼峰命名法：myAge，一般用于变量名。Pascal命名法：MyAge，一般用于方法和类

            //int count;
            //double ave;
            //double height;
            char sex;
            sex = '男';

            //新赋的值会将旧的值覆盖
            //变量需要先声明后使用
            Console.WriteLine(age+sex);
            

            int a = 1, b = 2;
            Console.WriteLine(a + b);//3
            Console.WriteLine("a+b");//a+b
            Console.WriteLine(a + "+" + b);//1+2
            Console.WriteLine("a+b" + a + b);//a+b12
            Console.WriteLine("a+b" + (a + b));//a+b3

            //字符类型和对应的整数
            char A = 'c';//每一个字符其实会对应一个整数
            int B = A;//赋值的前提，双方的类型一致（因为每个字符对应一个整数），容器小的可以赋值给容器大的
            Console.WriteLine(A);//c
            Console.WriteLine(B);//99
            //a-z对应97-122，A-Z对应65-90
            int C = 97;
            char D = (char)C;//整数int比字符char大，把大容器的放到小容器中需要进行强制类型转换
            Console.WriteLine(D);
            

            //数字字符
            char E = '1';
            int F = E;
            Console.WriteLine(F);//49 字符1是以数字49进行存储的
                                 //字符0-9对应48-57

            //转义字符
            char c = '\n';
            char d = '\\';
            char e = '\"';
            char f = '\t';
            int g = c;
            Console.WriteLine(g);
            

            //让转义字符失去作用
            Console.WriteLine("c:\\a\\b\\c");
            Console.WriteLine(@"c:\\a\\b\\c");//@让转义字符失去作用
            

            //声明一个字符串
            string str = @"www.sikiedu.com\""


nsiki";//使用@后字符串可以不用+就可以占用多行,里面需要使用"的话，得使用两个""来代表一个"
            Console.WriteLine(str);
            

            //字符串相加
            string str1 = "123" + "456";
            string str2 = "789";
            string st3 = str1 + str2 + 10;
            Console.WriteLine(str1 + str2+10);//将int的数字进行相加后，会把数字变为字符串
            Console.WriteLine(st3);

            //字符串的格式化输出
            Console.WriteLine(a + "+" + b + "=" + (a + b));
            Console.WriteLine("{0}+{1}={2}", a, b, a + b);
            Console.WriteLine("两个数相加{0}+{0}={2}", 1, 3, 2);//可以重复取，但是不能取不存在的值
            //不同类型的范围
            


            Console.ReadKey();
        }
    }
}
