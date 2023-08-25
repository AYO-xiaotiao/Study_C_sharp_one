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
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
            Console.ReadKey();

            //倒序遍历
            //for(int i = str.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(str[i]);
            //}

            //字符串操作
            //string name = "   Meacheal   ";
            //string str1 = name.ToLower();//将字符串中的字母全部转换为小写，但是原变量中的不会改变，需要一个新的变量来接收这个改变的值
            //string str2 = name.ToUpper();//将字符串中的字母全部转换为大写
            //string str3 = name.Trim();//去除字符串前面和后面的空格
            //string str4 = name.TrimStart();//去除字符串前面的空格
            //string str5 = name.TrimEnd();//去除字符串后面的空格
            //string name1 = "xiaoming,xiaofang,xiaolv";
            //string[] str6 = name1.Split(',');//将字符串里面的数据按照,进行分割，。分割的数据用字符串数组进行保存
            //foreach(string i in str6)
            //{
            //    Console.WriteLine(i);
            //}//将分割后的字符串输出出来

            //3个可乐瓶可以换一瓶可乐，现在有364瓶可乐，问一共可以喝多少瓶可乐，剩下多少空瓶
            //int i = 364;
            //int j = 364;
            //while (i>2)
            //{
            //    j += i / 3;
            //    i = (i / 3) + (i % 3);
            //}
            //Console.WriteLine("一共可以喝{0}，剩下{1}", j, i);

            //编写一个程序用来输入的字符串进行加密，对于字母字符串加密规则如下：'a'->'d','b'->'e','A'->'D','B'->'E'，对于其他的字符不进行加密
            //string str = Console.ReadLine();
            //string str1 = "";
            //foreach (char c in str)
            //{
            //    if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
            //    {
            //        int d = c + 3;
            //        if ((d > 'z' && d < 'z' + 4) || (d > 'Z' && d < 'Z' + 4))
            //        {
            //            char f = (char)(d - 26);
            //            str1 += f;
            //        }
            //        else
            //        {
            //            char e = Convert.ToChar(d);
            //            str1 += e;
            //        }
            //    }
            //    else
            //    {
            //        str1 += c;
            //    }
            //}
            //Console.WriteLine(str1);
            //方式二
            //string str = Console.ReadLine();
            //char[] strArray = str.ToCharArray();
            //for(int i = 0; i < strArray.Length; i++)
            //{
            //    if ((strArray[i] >= 'a' && strArray[i] <= 'z') || (strArray[i] >= 'A' && strArray[i] <= 'Z'))
            //    {
            //        strArray[i] = (char)(strArray[i] + 3);
            //        if((strArray[i]>'z'&& strArray[i] < 'z' + 4)|| (strArray[i] > 'Z' && strArray[i] < 'Z' + 4))
            //        {
            //            strArray[i] = (char)(strArray[i] - 26);
            //        }

            //    }
            //}
            //foreach(char temp in strArray)
            //{
            //    Console.WriteLine(temp);
            //}

            //输入n个数（n<100）个数，找出其中最小的数，将它与前面的数交换后输出这些数
            //string num = Console.ReadLine();
            //string[] num1 = num.Split(' ');
            //int[] intArray = new int[num1.Length];
            //for (int i = 0; i < num1.Length; i++)
            //{
            //    intArray[i] = Convert.ToInt32(num1[i]);
            //}
            //int min = intArray[0];
            //int minIndex =0;
            //for(int i = 1; i < intArray.Length; i++)
            //{
            //    if (min > intArray[i])
            //    {
            //        min = intArray[i];
            //        minIndex = i;
            //    }
            //}
            //int temp1 = intArray[0];
            //intArray[0] = intArray[minIndex];
            //intArray[minIndex] = temp1;
            //Console.WriteLine(min);
            //foreach (int temp in intArray)
            //{
            //    Console.Write(temp + " ");

            //}

            //有n（n<100）个整数，已经按照从小到大排序好，现在另外给一个整数x，请将该数插入到序列中，并使新的序列依然有序
            //int[] intArray = { 1, 2, 3, 5, 9, 10 };
            //int[] intArray1 = new int[intArray.Length+1];
            //int x = Convert.ToInt32(Console.ReadLine());
            //for(int i = 1; i < intArray.Length; i++)
            //{
            //    if (x >= intArray[i] && x < intArray[i + 1])
            //    {
            //        for(int j = 0; j <= i; j++)
            //        {
            //            intArray1[j] = intArray[j];
            //        }
            //        intArray1[i + 1] = x;
            //        for (int k = i + 2; k < intArray1.Length; k++)
            //        {
            //            intArray1[k] = intArray[k - 1];
            //        }
            //    }
            //}
            //foreach(int n in intArray1)
            //{
            //    Console.Write(n+" ");
            //}

            //排序方法
            //int[] intArray = { 99, 2, 9, 60, 9, 10 };
            //Array.Sort(intArray);
            //foreach(int n in intArray)
            //{
            //    Console.Write(n+" ");
            //}

            //排序代码实现
            //数据输入为int类型的数组
            //string str = Console.ReadLine();
            //string[] strArray = str.Split(' ');
            //int[] intArray = new int[strArray.Length];
            //for (int i = 0; i < strArray.Length; i++)
            //{
            //    intArray[i] = Convert.ToInt32(strArray[i]);
            //}

            //Console.ReadKey();
        }
    }
}
