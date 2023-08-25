using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_6_变量的作用域
{
    class Program
    {
        static void Main(string[] args)
        {
            //局部变量和全局变量
            int a = 10;//外层变量
            if (true)
            {
                int b = 100;//内层变量
                Console.WriteLine(a + b);//外层变量可以被内层使用

            }
            for(int i = 0; i < 10; i++)
            {

            }
            for (int i = 0; i < 10; i++)//不同for循环里面的变量可以重名，也可以说同层是可以重名的
            {

            }


            //Console.WriteLine(b);//外层无妨使用内层变量

        }
    }
}
