/* Получить на вдох число и проверить кратно оно 7 и 23 одновременно */


int GetNumber()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

Console.WriteLine("Напишите число");
int Number = GetNumber();

if (Number % 7 == 0 && Number % 23 == 0)
{
    Console.WriteLine($"Число {Number} кратно 7 и 23");
}
else
{
    Console.WriteLine($"Число {Number} не кратно 7 и 23");
}
