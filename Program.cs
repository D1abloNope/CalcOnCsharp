Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите операцию");
char operation = Convert.ToChar(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
int results = (0);
if (operation == '+')
{
    results += num1 + num2;
    Console.WriteLine(num1 + "+" + num2 + "=" + results);
}

else if (operation == '-')
{
    results += num1 - num2;
    Console.WriteLine(num1 + "-" + num2 + "=" + results);
}

else if (operation == '*')
{
    results += num1 * num2;
    Console.WriteLine(num1 + "*" + num2 + "=" + results);
}

else if (operation == '/')
{
    if (num2 == 0)
    {
        Console.WriteLine("Нельзя делить на 0");
    }
    else
    {
        results += num1 / num2;
        Console.WriteLine(num1 + "/" + num2 + "=" + results);
    }
}
else
{
    Console.WriteLine("Неизвестный оператор");
}