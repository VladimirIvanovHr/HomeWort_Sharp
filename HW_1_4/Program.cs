Console.WriteLine("Введите число больше 0:");
int N = Convert.ToInt32(Console.ReadLine());
int number = 2;
if (N<=0)
{
Console.WriteLine("неверное число");
}
else while (number <= N)
{
    Console.Write(number + ", ");
    number = number + 2;
}
Console.WriteLine();
