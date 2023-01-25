/* Задача 26: Напишите программу, которая принимает на вход 
число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 

1.Подаем число
2.Считаем количесвто цифр 
3.Выводим на экран

*/

int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Повторите ввод!\n");
        }
    }

    return Math.Abs(result);
}

void GetLong(int GetNumber)
{
    string GetText = GetNumber.ToString();
    int longText = GetText.Length;
    Console.WriteLine(longText);

}

int number = GetNumber("Введиет любое число:");

GetLong(number);
