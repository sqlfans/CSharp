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
