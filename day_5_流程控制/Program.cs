using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_5_流程控制
{
    class Program
    {
        static void Main(string[] args)
        {
            //条件语句
            //if
            //大于16岁
            //int age = Convert.ToInt32(Console.ReadLine());
            //if (age >= 16)
            //{
            //    Console.WriteLine("可以进入");
            //}
            //else if (age>0&&age < 16)
            //{
            //    Console.WriteLine("小于16");
            //}
            //else
            //{
            //    Console.WriteLine("输入有误");
            //}

            ////筛选年龄为18-30，且为奇数
            ////方式一
            //int age1 = Convert.ToInt32(Console.ReadLine());
            //if (age1>=18&&age1<=30&&age1%2==1) {
            //    Console.WriteLine("符合条件");
            //}
            ////方式二
            //if(age1 >= 18 && age1 <= 30)
            //{
            //    Console.WriteLine("可以参加");
            //    if (age1 % 2 == 1)
            //    {
            //        Console.WriteLine("获得奖品");
            //    }
            //    else
            //    {
            //        Console.WriteLine("没有获得奖品");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("不可以参加");
            //}


            //int x = Convert.ToInt32(Console.ReadLine());
            //int y = Convert.ToInt32(Console.ReadLine());
            //if (x > 0 && y > 0)
            //{
            //    Console.WriteLine("第一象限");
            //}
            //else if (x < 0 && y > 0)
            //{
            //    Console.WriteLine("第二象限");
            //}
            //else if (x < 0 && y < 0)
            //{
            //    Console.WriteLine("第三象限");
            //}
            //else if (x > 0 && y < 0)
            //{
            //    Console.WriteLine("第四象限");
            //}
            //else if (0==x && y != 0)
            //{
            //    Console.WriteLine("y轴");
            //}
            //else if (0 == y && x != 0)
            //{
            //    Console.WriteLine("x轴");
            //}
            //else
            //{
            //    Console.WriteLine("原点");
            //}

            //char a = Convert.ToChar(Console.ReadLine());
            //char b = Convert.ToChar(Console.ReadLine());
            //if (a > b)//字符可以直接进行比较
            //{
            //    Console.WriteLine("{0}>{1}", a, b);
            //}
            //else
            //{
            //    Console.WriteLine("{0}<{1}", a, b);
            //}

            //输入三个整数，然后将三个整数进行从小到大的排序
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());
            ////冒泡排序法
            //if (a > b)
            //{
            //    int temp = b;
            //    b = a;
            //    a = temp;
            //}
            //if (b > c)
            //{
            //    int temp = c;
            //    c = b;
            //    b = temp;
            //}
            //if (a > b)
            //{
            //    int temp = b;
            //    b = a;
            //    a = temp;
            //}
            //Console.WriteLine("" + a + " "+ b + " " + c);

            //输入一个小数和整数K（K为0或1）如果K为0，则输出m保留整数部分，如果K为1，则输出m四舍五入保留一位小数
            //double a = Convert.ToDouble(Console.ReadLine());
            //int k = Convert.ToInt32(Console.ReadLine());
            //if (k == 0)
            //{
            //    int b = (int)a;
            //    Console.WriteLine(b);
            //}
            //else if(k==1)
            //{
            //    double c = ((int)((a + 0.05)*10))/10.0;
            //    Console.WriteLine(c);

            //}
            //else
            //{
            //    Console.WriteLine("k输入有误");
            //}

            //switch语句
            //问题：有一台自动售货机，里面一共有6个商品，用户可以输入1-6进行选择想要的商品，1-矿泉水，2-红茶，3-绿茶，4-雪碧，5-可口可乐，6-脉动
            //根据用户输入的数字进行选择相应的商品
            //int a = Convert.ToInt32(Console.ReadLine());
            //switch(a)
            // {
            //    case 1:
            //        Console.WriteLine("矿泉水");
            //        break;
            //    case 2:
            //        Console.WriteLine("红茶");
            //        break;
            //    case 3:
            //        Console.WriteLine("绿茶");
            //        break;
            //    case 4:
            //        Console.WriteLine("雪碧");
            //        break;
            //    case 5:
            //        Console.WriteLine("可口可乐");
            //        break;
            //    case 6:
            //        Console.WriteLine("脉动");
            //        break;
            //    default://这可以不写，默认情况，只有当前面的条件都不满足时输出
            //        Console.WriteLine("没有你要的商品");
            //        break;
            //}

            //switch (a)
            //{
            //    case 1:
            //    case 2://这样表示或的关系
            //        Console.WriteLine("水");
            //        break;
            //    case 3:
            //        Console.WriteLine("红茶");
            //        break;
            //}

            //if和switch的异同
            //异：
            //switch：判断相等
            //if进行范围判断
            //同：都是分支语句

            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());
            //int d = Convert.ToInt32(Console.ReadLine());
            //int max = a, min = a;
            //if (b > max)
            //{
            //    max = b;
            //}
            //if (c > max)
            //{
            //    max = c;
            //}
            //if (d > max)
            //{
            //    max = d;
            //}
            //if (b < min)
            //{
            //    min = b;
            //}
            //if (c < min)
            //{
            //    min = c;
            //}
            //if (d < min)
            //{
            //    min = d;
            //}
            //Console.WriteLine("最大值是{0}，最小值是{1}", max, min);

            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int op = Convert.ToInt32(Console.ReadLine());
            //int res = 0;
            //switch (op)
            //{
            //    case 1:
            //        res = a - b;
            //        Console.WriteLine(res);
            //        break;
            //    case 2:
            //        res = a + b;
            //        Console.WriteLine(res);
            //        break;
            //    case 3:
            //        res = a * b;
            //        Console.WriteLine(res);
            //        break;
            //    case 4:
            //        double res1 = a*1.0 / b;
            //        Console.WriteLine(res1);
            //        break;
            //}

            //循环语句
            //while循环
            //int i = 1;//i的初始值
            //while (i<=10){//括号里面为判断条件，如果是true则是死循环
            //    Console.Write(i+" ");
            //    i++;//增量表达式
            //}

            //输入整数n，一直从1加到n
            //int n = Convert.ToInt32(Console.ReadLine());
            //int i = 1;
            //int sum = 0;
            //while (i <= n)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);

            //输出1-100之间所有的偶数
            //int i = 1;
            //while (i <= 100)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //遍历n1-n2之间的偶数
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //int i = n1;
            //while (i <= n2)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //3n+1问题
            //int n = Convert.ToInt32(Console.ReadLine());
            //int num = 0;
            //while (n != 1)//终止条件
            //{
            //    if (n % 2 != 0)
            //    {
            //        n=3*n + 1;

            //    }
            //    else
            //    {
            //        n = n / 2;

            //    }
            //    Console.WriteLine("n的值" + n);
            //    num++;
            //}
            //Console.WriteLine(num);

            //2006年培养学员8万人，每年增长25%，请问按此增长率，哪一年的人数将达到20万
            //double i = 8;
            //int j = 0;
            //while (i < 20)
            //{
            //    i = (1 + 0.25) * i;
            //    j++;
            //}
            //Console.WriteLine(2006 + j);

            //班上有若干名学生，输入学生的个数 ，然后输入每一个学生的年龄，计算出平均年龄，保留到小数点后两位，输出平均年龄
            //int num = Convert.ToInt32(Console.ReadLine());
            //int i = 1;
            //int sum = 0;
            //while (i <= num) {
            //    int age = Convert.ToInt32(Console.ReadLine());
            //    sum += age;
            //    i++;
            //}
            //double ave = ((int)((sum * 1.0 / num)*100))/100.0;
            //Console.WriteLine(ave);

            //for循环
            //for (int i =1;i<11 ;i++ )//(初始化;判断条件;增量表达式)
            //{
            //    Console.WriteLine(i);//循环体
            //}

            //输入两个正整数n和m，利用for循环打印出n和m之间所有的奇数和偶数，奇数放一行，偶数放一行，使用空格隔开
            //int n = Convert.ToInt32(Console.ReadLine());
            //int m = Convert.ToInt32(Console.ReadLine());
            //string ji = "";
            //string ou = "";
            //for(int i = n; i < m + 1; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        ji += i+" ";

            //    }
            //    else
            //    {
            //        ou += i+" ";

            //    }
            //}
            //Console.WriteLine("奇数有{0}", ji);
            //Console.WriteLine("偶数有{0}", ou);

            //do while循环 先不管判断条件执行一次循环语句，然后再根据判断条件执行循环语句
            //int i = 1;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i<11);

            //for循环的其他情况
            //for循环的初始化 条件 增量都是可选的，可有可无，根据需要。一般都有
            //同一个作用域内变量不能重名
            //int i = 1;
            //for (; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //for (; i < 10; )
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //for (; ;)//判断条件要是没有了就直接进入死循环了
            //{
            //    Console.WriteLine(i);
            //    i++;
            //    //可以使用break退出循环
            //    if (i > 10)
            //    {
            //        break;//跳出离它最近的循环
            //    }
            //}
            //循环总结
            //for 确定循环次数
            //while 确定循环条件
            //do while 不经过判断循环被执行一次在判断是否执行

            //让用户输入整数，如果用户输入的不是0，就继续输入，如果输入的是0，结束整数，并输出所有整数的和
            //int num = 0;
            //int sum = 0;
            //do
            //{
            //    num = Convert.ToInt32(Console.ReadLine());
            //    sum += num;
            //} while (num != 0);
            //Console.WriteLine(sum);

            //一个球从某高度落下来，每次落地后反弹回原来一半的高度，在落下。计算球第10次反弹的高度，第十次落地后经过了多少米。
            //输入球的初始高度，输出反弹多高，和经过多少米
            //int initialHeight = Convert.ToInt32(Console.ReadLine());
            //double totalHeight = initialHeight;
            //double height = initialHeight;
            //int num = 0;
            //do
            //{
            //    height = height / 2.0;
            //    totalHeight += (2*height);
            //    num++;
            //} while (num<10);
            //totalHeight -= 2 * height;
            //Console.WriteLine("第10次反弹的高度{0}，经过的总高度{1}", height, totalHeight);

            //输入一个整数a，和一个正整数n，计算乘方a的n次方
            //int a = Convert.ToInt32(Console.ReadLine());
            //uint n = (uint)Convert.ToInt32(Console.ReadLine());
            //int i = 1;
            //do
            //{
            //    if (n != 1) 
            //    { 
            //        a *= a;
            //        i++;
            //    }
            //} while (i < n );
            //Console.WriteLine(a);

            //输入整数n，求n的阶乘
            //int n = Convert.ToInt32(Console.ReadLine());
            //int j = 1;
            //for(int i = 1; i < n + 1; i++)
            //{
            //    j *= i;
            //    //Console.WriteLine(i);
            //}
            //Console.WriteLine(j);

            //输入q和n
            //int q = Convert.ToInt32(Console.ReadLine());
            //int n = Convert.ToInt32(Console.ReadLine());
            //int num = 1;
            //int sum = 1;
            //for(int i = 1; i < n + 1; i++)
            //{
            //     num *= q;
            //     sum += num;
            //}
            //Console.WriteLine(sum);

            //已知：Sn=1+1/2+1/3+...+1/n。显然对于任意一个整数k，当n足够大的时候，Sn大于k。现输入一个整数k（1<=k<=15)，要求计算出一个最小的n，使得Sn>k。
            //样例输入1，输出2
            //Console.WriteLine("请输入一个大于等于1且小于等于15的整数");
            //int k = Convert.ToInt32(Console.ReadLine());
            //if (k >= 1 && k <= 15)
            //{
            //    int i = 1;
            //    double Sn = 0;
            //    int n = 0;
            //    while (Sn <= k)
            //    {
            //        Sn += (1.0 / i);
            //        i++;
            //        n++;
            //    }
            //    Console.WriteLine(n);
            //}
            //else
            //{
            //    Console.WriteLine("输入k值错误，请按照提示大小输入");
            //}

            //我国现在有x亿人口，按照每年0.1%的增长速度，n年后将有多少人？
            //int n = Convert.ToInt32(Console.ReadLine());
            //double number = Convert.ToInt32(Console.ReadLine());
            //for(int i = 1; i < n + 1; i++)
            //{
            //    number += (0.001 * number);
            //    //number *= 1.001;
            //}
            //Console.WriteLine(number);

            //农夫约翰在去年赚了一大笔钱，他想要把这笔钱用于投资，并对自己能得到多少收益感到好奇。已知投资的复合年利率为R（0-20之间的整数）
            //约翰现有总值为M的钱（M为100到1000000之间的整数）。他清楚地知道自己要投资Y年（范围0-40）请帮助他计算他最终会有多少钱，并输出
            //double R = (Convert.ToInt32(Console.ReadLine())) / 100.0;
            //double M = Convert.ToInt32(Console.ReadLine());
            //int Y = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i < Y + 1; i++)
            //{
            //    M += (R * M);
            //}
            //Console.WriteLine(M);

            //提高理财意识is very important，复利是十分强大的

            //编写一个程序，打印出所有的水仙花数，指的是一个三位数，其各位数字立方等于该数本身。例如153=1*1*1+5*5*5+3*3*3，所以153是水仙花数
            //for(int i = 100; i < 1000; i++)
            //{
            //    int ge = i % 10;
            //    int shi = i / 10 % 10;
            //    int bai = i / 100 % 10;
            //    if (ge * ge * ge + shi * shi * shi + bai * bai * bai == i)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //输入任意一个位数未知的整数，输出这个数每一位的数字，从个位开始输出，每输出一个换一行。
            //int n = Convert.ToInt32(Console.ReadLine());
            //while (n!=0)
            //{
            //    int i = n % 10;
            //    Console.WriteLine(i);
            //    n/=10;
            //}

            //随即输入任意一个位数位置的整数，去除这个数上面的所有0，形成新的数，并进行输出
            //int n = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //int cheng = 1;
            //while (n!=0)
            //{
            //    int i = n % 10;

            //    if (i != 0)
            //    {
            //        i *= cheng;
            //        sum += i;
            //        cheng *= 10;
            //    }
            //    n /= 10;
            //}
            //Console.Write(sum);

            //时间有限，学完C#就进行汇川的学习
            //随机输入一个整数num，输出一个新的数，新数恰好与原数每一位上的数字相反，（如果原数末尾有多个零，输出的新数高位不含0）
            //int num = Convert.ToInt32(Console.ReadLine());
            //bool yuDao = false;
            //while (num!=0)//从低位到高位进行遍历
            //{
            //    int i = num % 10;
            //    //判断第一个数字是否等于0
            //    if (yuDao==false)
            //    {
            //        if (i != 0)
            //        {
            //            Console.Write(i);
            //            yuDao = true;
            //        }
            //    }
            //    else
            //    {
            //        Console.Write(i);
            //    }
            //    num /= 10;
            //}

            //输入一个数判断是否是回文数，如果是输出yes，如果不是输出no
            //int num = Convert.ToInt32(Console.ReadLine());
            //int n = num;
            //int num1 = 0;
            //while (num != 0)
            //{
            //    int i = num % 10;
            //    num1 *= 10;
            //    num1 += i;

            //    num /= 10;
            //}
            //Console.WriteLine(num1);
            //if (n == num1)
            //{
            //    Console.WriteLine("yes");
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}

            //数字和字符混合在一起了，作为一个优秀的挖掘人员，把输入的数字挖出来，并计算这些数字的和，并输出，输入以@作为结束
            //string a = Console.ReadLine();
            //int sum = 0;
            //foreach (char i in a)
            //{
            //    if(Char.IsDigit(i))//判断字符是否为数字
            //    {
            //        //Console.WriteLine(i);
            //        int j = i-48;
            //        //Console.WriteLine(j);
            //        sum += j;
            //    }
            //    else if(i == '@')
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine(sum);

            //方式二
            //char c;
            //int sum = 0;
            //do
            //{
            //    c = (char)Console.Read();
            //    if (c >= '0' && c <= '9')
            //    {
            //        int number = c - '0';
            //        sum += number;
            //    }
            //} while (c != '@');
            //Console.WriteLine(sum);
            //输入Read()单个字符时，换行符也会读取

            //假设有一个隧道，隧道以字符'#'结束，挖矿的过程中，会遇到钻石'*'和美金'1-9'，让矿工小六挖到隧道的尽头，假设每个钻石3价值500美金
            //，统计小六挖到了价值多少的美金收入
            //char c;
            //int sum = 0;
            //do
            //{
            //    c = (char)Console.Read();
            //    if (c >= '1' && c <= '9')
            //    {
            //        int number = c - '0';
            //        sum += number;
            //    }
            //    else if (c == '*')
            //    {
            //        sum += 500;
            //    }
            //} while (c != '#');
            //Console.WriteLine(sum);

            //输入一个整数，输出该整数的因数个数和所有因数
            //输入的整数大于0，小于100000
            //int n = Convert.ToInt32(Console.ReadLine());
            //int count = 0;
            //string str = "";
            //for (int i = 1; i < n + 1; i++)
            //{
            //    if (n % i == 0)
            //    {
            //        count++;
            //        str += i + " ";
            //            }
            //}
            //Console.WriteLine(count);
            //Console.WriteLine(str);

            //判断一个数是否是质数
            //int n = Convert.ToInt32(Console.ReadLine());
            //int count = 0;

            //for (int i = 1; i < n + 1; i++)
            //{
            //    if (n % i == 0)
            //    {
            //        count++;
            //    }
            //    if (count == 2)
            //    {
            //        Console.WriteLine("yes");
            //    }
            //    else
            //    {
            //        Console.WriteLine("no");
            //    }
            //}

            //continue 终止当前循环,继续下次循环
            //for(int i = 1; i < 101; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}

            //break 终止整个循环
            //break和continue都只作用于最近的循环

            //循环嵌套
            //for(int i = 1; i < 5; i++)
            //{
            //    for(int j = 1; j < 11; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //输入整数n，输出n层的三角形
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i =1; i < n + 1; i++)
            //{
            //    for(int j=1; j<i+1; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //输入整数n，输出n层的三角形的斜边
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i < n + 1; i++)
            //{
            //    for (int j = 2; j < i + 1; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine("*");
            //}

            //输入整数n，输出n层三角形的倒斜边
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i < n + 1; i++)
            //{
            //    for (int j = 0; j < n-i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine("*");
            //}

            //输入一个正整数n，输出n行，每行n个*的平行四边形
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i < n + 1; i++)
            //{
            //    for (int j = 2; j < i + 1; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine("****");
            //}

            //输入一个正整数n，输出n层的右三角形
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i < n + 1; i++)
            //{
            //    for (int j = 0; j < n - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int k = 1; k < i+1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //输出一个正整数，输出n层的等腰三角形
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i < n + 1; i++)
            //{
            //    for (int j = 0; j < n - i; j++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k < 2*i; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //输入一个正整数，输出n层的菱形
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i < n + 1; i++)
            //{
            //    for (int j = 0; j < n - i; j++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k < 2 * i; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for(int i = 1;i<n; i++)
            //{
            //    for(int j = 1; j < i + 1; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int k = 2 * (n - i)-1; k != 0; k--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //输出9×9乘法表
            //for(int i = 1; i < 10; i++)
            //{
            //    for(int j = 1; j < i+1; j++)
            //    {
            //        Console.Write("{0}×{1}={2} ", i, j, i * j);
            //    }
            //    Console.WriteLine();
            //}

            //用100文钱买100只鸡，其中公鸡，母鸡，小鸡都必须要有，公鸡3文1只，母鸡5文1只，小鸡2文1只，请问公鸡，母鸡，小鸡要各买多少刚好
            //凑齐100只，把所有条件罗列出来
            //int gonJi = 3;
            //int muJi = 5;
            //int xiaoJi = 2;
            //for(int gonJiN = 1; gonJiN < 100/3; gonJiN++)
            //{
            //    for(int muJiN = 1; muJiN < 100/5; muJiN++)
            //    {
            //        for(int xiaoJiN = 1; xiaoJiN < 100/2; xiaoJiN++)
            //        {
            //            if ((gonJiN * gonJi + muJiN * muJi + xiaoJiN * xiaoJi )== 100)
            //            {
            //                Console.WriteLine("小鸡：{0}，公鸡：{1}，母鸡：{2}", xiaoJiN, gonJiN, muJiN);
            //            }
            //            else
            //            {
            //                continue;
            //            }
            //        }   
            //    }
            //}

            //输入两个整数num1和num2，输出这两个正整数num1和num2的最大公约数
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //int max = 0;
            //for (int i = 1; i < num1 && i < num2; i++)
            //{
            //    if (num1 % i == 0 && num2 % i == 0)
            //    {
            //        max = i;
            //    }
            //}
            //Console.WriteLine(max);

            //猜数字
            //由系统生成一个随机数（1-100），让玩家猜数字，如果猜的数字比随机数小，输出猜小了，如果猜的数字比随机数大，输出猜大了，猜中了
            //的话，结束游戏，没有猜中则继续让玩家猜
            //随机数的生成Random
            Random rd = new Random();
            int num = rd.Next(1, 101);//生成1-9的随机数
            while (true)
            {
                int i = Convert.ToInt32(Console.ReadLine());
                if (i == num)
                {
                    Console.WriteLine("猜中了");
                    break;
                }
                else if (i > num)
                {
                    Console.WriteLine("猜大了");
                }
                else if (i < num)
                {
                    Console.WriteLine("猜小了");
                }
            }
            Console.ReadKey();

        }
    }
}

