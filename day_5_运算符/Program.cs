using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_5_运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            //数字运算符
            //+ - * / %(求余)
            //int a = 23 + 23;
            //int b = 2 - 10;
            //int c = 4 * 25;
            //int d = 45 / 10;//会自动省略小数部分
            //double f = 45 / 10.0;//只要运算两边有一个小数，最后的结果就是小数
            //int e = 45 % 10;

            //获得十位个位
            //int num = 39;
            //int ge = num % 10;
            //int shi = num / 10;
            //Console.WriteLine("个位数是{0}，十位数是{1}", ge, shi);

            //赋值运算符
            //int a = 0;
            //a = a + 1;
            //a += 1;//这里等于a = a + 1;

            //自增自减运算符
            //int b = 1;
            //b++;//自身增加1
            //b--;//自身减少1
            //Console.WriteLine(b);
            //先赋值，再自增
            //int c = b++;
            //Console.WriteLine(c);
            //先自增，再赋值
            //int d = ++b;
            //Console.WriteLine(d);
            //int e = 1;
            //Console.WriteLine(++e);//2
            //Console.WriteLine(e++);//2
            //Console.WriteLine(e);

            //关系运算符和布尔类型
            //bool a = true;//1 真的 是的 满足条件
            //bool b = false;
            ////复制一行代码时可以使用ctrl+d
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //== > < >= <= !=，返回的是bool类型
            //bool a = 45 == 70;
            //bool b = 45 <= 70;

            ////逻辑运算符
            ////&&：逻辑与 ||：逻辑或 ！：逻辑非，取反
            //bool c = (3 > 4) && (9 > 6);//false，需要两边都满足
            //bool d = (3 > 4) || (9 > 6);//true，只要其中一个满足就可以了
            //bool e = !(4 < 7);//false，将括号里面的bool值取反
            ////判断一个是否为一个青年，青年的标准是18-60
            //int age = Convert.ToInt32(Console.ReadLine());
            //bool isYoung = age >= 18 && age <= 60;
            //Console.WriteLine(isYoung);

            //运算符的优先级
            //int a = 3 + 2 * 4;//先*/后+-
            //int age = Convert.ToInt32(Console.ReadLine());
            //bool isYoung = age >= 18 && age <= 60;//比较运算符大于逻辑运算符
            //()是最高优先级，通过括号进行控制

            //练习
            //int a = Convert.ToInt32(Console.ReadLine());
            //int ge = a % 10;
            //int shi = a / 10 % 10;
            //int bai = a / 100;
            //Console.WriteLine("" + ge + shi + bai);

            //加密和解密
            //int b = Convert.ToInt32(Console.ReadLine());
            //int shi = b / 10 % 10;
            //int qian = b / 1000 % 10;
            //int number = qian * 10 + shi;
            //char c = (char)number;
            //Console.WriteLine(c);

            //int a = 3;
            //int b = a++ + a++;
            //Console.WriteLine(b);//7
            //Console.WriteLine(a);//5
            int a = 3;
            int b = a++ + ++a;
            Console.WriteLine(b);//8
            Console.WriteLine(a);//5







            Console.ReadKey();


        }
    }
}
