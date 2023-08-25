using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_7_数组
{
    class Program
    {
        static void Main(string[] args)
        {
            //数组：用来存储同种类型的大量数据

            //声明数组
            //int[] ages = { 1,4,6,8,9,90,100};//长度为7的数组
            //double[] n;
            //char[] temp1;
            //string[] temp2;

            //数组每个数据有下标，从0开始排的
            //Console.WriteLine(ages[0]);//1

            //赋值方式
            //int[] ages = { 1, 4, 6, 8, 9, 90, 100 };//长度为7的数组

            //int[] ages;
            //ages = new int[10];//数组长度为10 会按照默认值进行赋值，数字类型的默认值为0

            //int[] ages;
            //ages = new int[] {12,21,25,27 };//创建一个长度为4有值的数组

            //int[] ages;
            //ages = new int[4] { 12, 21, 25, 27 };//括号里面的长度和后面的值的数量要一致

            //ages[1] = 20;//对之前该位置的值进行覆盖
            //Console.WriteLine(ages[1]);//20
            //赋值和读取时不要超过索引值

            //声明一个int类型的数组，大小为9
            //int[] n;
            //n = new int[9];

            //int[] n1 = new int[9];
            //声明一个string类型的数组，大小为12
            //string[] str = new string[12];//默认值为null

            //数组的遍历
            int[] ages = { 1, 4, 6, 8, 9, 90, 100 };
            //for(int i = 0; i < ages.Length; i++)
            //{
            //    Console.WriteLine(ages[i]);
            //}

            //int i = 0;
            //while (i < ages.Length)
            //{
            //    Console.WriteLine(ages[i]);
            //    i++;
            //}

            //foreach
            //foreach (int temp in ages)
            //{
            //    Console.WriteLine(temp);
            //}//只能正序

            //倒序遍历
            for (int i = ages.Length-1; i >= 0; i--)
            {
                Console.WriteLine(ages[i]);
            }

            Console.ReadKey();




        }
    }
}
