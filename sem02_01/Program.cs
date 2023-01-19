/* Напишите программу, которая выводит случайное число из отрезка 
[10, 99] и показывает наибольшую цифру числа
Например: 78 -> 8
*/
/*
1. Метод, который получает случайное число
2. Метод, который получаем максимальную цифру числа
*/

int GetRandomNumber(int leftBound, int rightBound)
{
    int result = 0;
    Random rnd = new Random();

    result = rnd.Next(leftBound, rightBound + 1);

    return result;
}

int GetMaxDigitOfNumber(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;

    if (firstDigit > secondDigit)
        return firstDigit;
    else
        return secondDigit;
}

int number = GetRandomNumber(10, 99);
int maxDigit = GetMaxDigitOfNumber(number);

Console.WriteLine($"Маскимальная цифра числа {number} = {maxDigit}");