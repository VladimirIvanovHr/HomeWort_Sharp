Console.WriteLine("Сравним два числа?");
Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1==number2)
{
    Console.WriteLine("Числа равны");
}
else
{
    if (number1>number2)
{
    Console.WriteLine($"Больше число {number1}");
}  
    else
{
    Console.WriteLine($"Больше число {number2}");
}
}
