Console.WriteLine("Введите первое число:");
string numberStr1 = Console.ReadLine();
int a = Convert.ToInt32(numberStr1);

/*Принять два числа, первое является квадратом второго*/

Console.WriteLine("Введите второе число:");
string numberStr2 = Console.ReadLine();
int b = Convert.ToInt32(numberStr2);

int c = a/b;

if (c == b)
{
Console.WriteLine("Число является квадратом ");
}
else 
{
Console.WriteLine("Число не является квадратом");
}
