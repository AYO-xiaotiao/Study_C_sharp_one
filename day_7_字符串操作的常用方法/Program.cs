using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_7_字符串操作的常用方法
{
    class Program
    {
        static void Main(string[] args)
        {
            //字符串，由一个一个字符组合而成
            //使用""包裹
            //一个字符串可以当成一个字符数组，可以使用str.length,str[]
            //但是字符串是不可以进行修改的
            string str = "zhang";
            Console.WriteLine(str.Length);
            Console.WriteLine(str[0]);
            for(int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
            Console.ReadKey();

            //倒序遍历


        }
    }
}
