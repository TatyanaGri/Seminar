/* Напишите программу которая будет принимать на вход 
два числа, и выводить, является ли второе число кратное первому 
если число два не кратно числу один, то программа выводит 
остаток от деления
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

if (secondNumber % firstNumber == 0)
{
    Console.WriteLine("Число кратно первому числу");
}
else
{
    Console.WriteLine($"Остаток от деления равен = {secondNumber % firstNumber}");
}

