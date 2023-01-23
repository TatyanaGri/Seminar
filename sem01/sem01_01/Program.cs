/* Напишите программу которая на вход принимает число и выдает его умножение на самого себя */


Console.WriteLine("Введите число:");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);

int result = number * number;

Console.WriteLine($"Квадрат числа {number} = {result}");