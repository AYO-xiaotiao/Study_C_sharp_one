using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_3_基本语法总结
{
    class Program
    {
        static void Main(string[] args)
        {
            //最好一行一条语句
            Console.Write("Hello World\n");//书写完之后不会换行,\n是转义字符，代表换行
            Console.WriteLine("hello world");//书写完之后会换行
            Console.Write("Hello\t World");//\t是转义字符，代表一个制表符
            Console.WriteLine("\nSiKi说\"What is \\n\"");
            Console.ReadKey();
            //先把代码编译为程序集（exe.dll），程序集运行时才会编译成机械指令（JIT 及时编译）
            //优点.net框架运行的，可以使用该框架的功能

        }
    }
}
