/* Напишите программу которая принимает два числа и проверяет 
является ли одно число квадратом другого 
5, 25 -> да
-4, 16 -> да
8, 9 -> нет
*/


int GetNumber()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

Console.WriteLine("Напишите первое число");
int firstNumber = GetNumber();
Console.WriteLine("Напишите второе число");
int secondNumber = GetNumber();

if (firstNumber * firstNumber == secondNumber || secondNumber * secondNumber == firstNumber)
{
    Console.WriteLine($"Да");
}
else
{
    Console.WriteLine($"Нет");
}
