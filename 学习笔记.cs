//两个变量交换值练习
int x, y;
int temp;
x = 0;
y = 1;
Console.WriteLine(x.ToString(), y.ToString());
temp = x;
x = y;
y = temp;
Console.WriteLine(x.ToString(), y.ToString());

//时间练习
int second = 777777;
int days = second / (60 * 60 * 24);
days = second / (60 * 60 * 24);
int hours = days / (60 * 60);
hours = days % (60 * 60);
int minutes = hours / 60;
int seconds = hours % 60;
Console.WriteLine("{0}\t\t{1}\t{2}\t{3}\t{4}",second, days, hours, minutes, seconds);
//闰年判断标准：被4整除，排除被100整除，不排除被400整除
Console.WriteLine("闰年判断练习：");
Console.WriteLine("请输入年份：");
int year = Convert.ToInt32(Console.ReadLine());
bool nonlLeapYear, LeapYear;//是否是闰年，平年
isLeapYear = (year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0));
notislLeapYear = !LeapYear;
Console.WriteLine("年份{0}是否为闰年判断结果： {1}", isLeapYear);
//自增自减练习
int x;
x = 0;
Console.WriteLine("{0}", x);//0
++x;
Console.WriteLine("{0}", x);//1
Console.WriteLine("{0}", ++x);//2
++x;
Console.WriteLine("{0}", x);//3
Console.WriteLine("{0}", ++x);//4
int y;
y = 0;
Console.WriteLine("{0}", y);//0
y++;
Console.WriteLine("{0}", y);//1
Console.WriteLine("{0}", y++);//1
y++;
Console.WriteLine("{0}", y);//3
Console.WriteLine("{0}", y++);//3
int z = 0;
Console.WriteLine(z.ToString());//0
Console.WriteLine((--z).ToString());//-1
Console.WriteLine((--z).ToString());//-2
Console.WriteLine((z--).ToString());//-2
Console.WriteLine((z--).ToString());//-3

//用户是否结婚年龄判断练习
Console.WriteLine("请输入年龄：");
int age = Convert.ToInt32(Console.ReadLine());
if (age >= 20)
{
	Console.WriteLine("您好，您已达到中华人民共和国法定结婚年龄。");
}
//isage储存判断结果
bool isage = (age >=20);//加上括号好习惯
if (isage)
{
	Console.WriteLine("您好，您已达到中华人民共和国法定结婚年龄。");
}

//成绩判断练习
//如果语文数学均为优秀（>80）或（语文>92数学>70）均判断为合格
Console.WriteLine("请输入语文成绩：");
int chinaese = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("请输入数学成绩：");
int math = Convert.ToInt32(Console.ReadLine());
bool istrue = ((chinaese>80 && math>80)||(chinaese>92&&math>85));
if (istrue)
{
	Console.WriteLine("非常优秀！");
}


//学习成绩判断
// 成绩 >= 90  :  A 
// 成绩 >= 80  :  B
// 成绩 >= 70  :  C
// 成绩 >= 60  :  D
// 成绩 >   60  :  E
Console.WriteLine("请输入成绩：");
int score = Convert.ToInt32(Console.ReadLine());
if (score >= 90 && score<=100)
{
	Console.WriteLine("A");
}
if (score >= 80 && score < 90)
{
	Console.WriteLine("B");
}
if(score >= 70 && score < 80)
{
	Console.WriteLine("C");
}
if (score >= 60 && score < 70)
{
	Console.WriteLine("D");
}
if (score < 60 && score >= 0)
{
	Console.WriteLine("E");
}
else
{
	Console.WriteLine("输入错误！！！");
}

Console.ReadLine();
