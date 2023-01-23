/* Программа которая вывод случайное трехзначное
 число и удаляет вторую цифру этого числа
 456 -> 46 
  */

int GetRandomValue()
{
    return new Random().Next(100, 1000);
}

int DeletSecondNumber(int number)
{
    return (number / 100) * 10 + (number % 10);
}

int number = GetRandomValue();
int result = DeletSecondNumber(number);
Console.WriteLine($"Было {number}, стало {result}");