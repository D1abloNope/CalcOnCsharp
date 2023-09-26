Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine()); // следовало добавить обработку исключения на случай, если не удалось конвертировать строку в число (например ввели дробное число или буквы)
Console.WriteLine("Введите операцию");
char operation = Convert.ToChar(Console.ReadLine()); // следовало добавить обработку исключения на случай, если не удалось конвертировать строку в символ (например ввели больше 1 символа)
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine()); // следовало добавить обработку исключения на случай, если не удалось конвертировать строку в число (например ввели дробное число или буквы)
// перебор операций удобнее делать через конструкцию switch case
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
