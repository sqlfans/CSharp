//打印10遍字符
while (x < 10)
{
	x++;
	Console.WriteLine("我以后再也不开小差了。{0}", x.ToString());//打印10次
	//x++;//注意本次打印和上面x++在console前打印有什么区别
}


//输入班级人数和每个人分数求平均值
Console.WriteLine("请输入班级人数：");
int count = Convert.ToInt32(Console.ReadLine());
int sum ,i;//两个临时变量，sum表示总和，i表示循环体中介条件参数
sum = i = 0;
while (i < count)
{
	Console.WriteLine("请输入{0}个人分数：",i);
	int score = Convert.ToInt32(Console.ReadLine());
	i++;
	sum = sum + score;
}
Console.WriteLine("总人数{0}，总成绩\t{1}，平均分数\t{2}。",count,sum,sum/count);

Console.WriteLine("学会了吗？输入y 或 n：");
string isnot = Console.ReadLine();
int i = 0;
while (isnot == "y")
{
	Console.WriteLine("放学去吧。");
	break;
}
while (i < 10 && isnot == "n")
{
	++i;
	Console.WriteLine("第{0}次讲解。", i);
}
Console.WriteLine("今天太累了，先回去吧，明天继续努力。");
Console.ReadLine();
