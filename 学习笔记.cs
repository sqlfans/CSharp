//交换变量练习
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
LeapYear = (year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0));
nonlLeapYear = !LeapYear;
Console.WriteLine("年份{0}是否为闰年判断结果： {1}", year, LeapYear);