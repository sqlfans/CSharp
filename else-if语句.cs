Console.WriteLine("三个数字比大小练习：");
Console.WriteLine("请输入第1个数字：");
int NumberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("请输入第2个数字：");
int NumberTwo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("请输入第3个数字：");
int NumberThree = Convert.ToInt32(Console.ReadLine());
if (NumberOne > NumberTwo && NumberOne > NumberThree)
{
	Console.WriteLine(NumberOne);
}
else if (NumberTwo > NumberOne && NumberTwo > NumberThree)
{
	Console.WriteLine(NumberTwo);
}
else if (NumberThree > NumberOne && NumberThree > NumberTwo)
{
	Console.WriteLine(NumberThree);
}
else
{
	Console.WriteLine("hhhhhh");
}

//密码输入练习，如果用户输入密码为888888，提示输入正确，否则再提示用户输入一次密码，并给出判断
Console.WriteLine("请输入密码：");
String password = Console.ReadLine();
if (password == "888888")
{
	Console.WriteLine("输入正确：");
}
else
{
	Console.WriteLine("输入错误：");
	Console.WriteLine("请重新输入密码：");
	password = Console.ReadLine();
	if (password == "888888")
	{
		Console.WriteLine("第二次输入正确：");
	}
	else
	{
		Console.WriteLine("密码输入两次错误。");
	}
}

//用户名密码判断练习
//正确用户名admin。正确密码888888，输入错误提示错误地方，并退出程序
Console.WriteLine("请输入用户名：");
String name = Convert.ToString(Console.ReadLine());
Console.WriteLine("请输入密码：");
String passwords = Convert.ToString(Console.ReadLine());
if(name=="admin" && passwords == "888888")
{
	Console.WriteLine("用户名和密码输入正确：");
}
if (name == "admin")
{
	if (passwords != "888888")
	{
		Console.WriteLine("密码输入错误！，程序退出。");
	}
}
if (passwords == "888888")
{
	if (name != "admin")
	{
		Console.WriteLine("用户名错误！，程序退出。");
	}
}
else
{
	Console.WriteLine("用户名和密码输入错误，程序退出。");
}


#异常处理学习
try
{
	Console.WriteLine("请输入年份");
	int year = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("请输入月份：");
	int month = Convert.ToInt32(Console.ReadLine());
	if(month > 12 && month <= 0) { return; }
	switch (month)
	{
		case 1:
		case 3:
		case 5:
		case 7:
		case 8:
		case 10:
		case 12:
			Console.WriteLine("31");
			break;
		case 4:
		case 6:
		case 9:
		case 11:
			Console.WriteLine("30");
			break;
		case 2:
			if ((year % 4 == 0) || (year % 400 == 0 && year % 100 != 0))
			{
				Console.WriteLine("29");
			}
			else
			{
				Console.WriteLine("28");
			}
			break;
	}
}
catch
{
	Console.WriteLine("年份或月份输入格式错误：");
}
		Console.ReadLine();
}
