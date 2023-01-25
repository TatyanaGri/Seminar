/* Задача 28: Напишите программу, которая принимает 
на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120 */

int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result >= 1)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Повторите ввод!\n");
        }
    }

    return result;
}

int GetMulti(int number)
{
    int multi = 1;
    
    for (int i = 1; i <= number; i++)
    {
        multi = multi * i;
    }

    return multi;
}

int number = GetNumber("Введиет число больше 1:");

int multi = GetMulti (number);

Console.WriteLine($"Произведение чисел от 1 до {number} равна {multi}");

