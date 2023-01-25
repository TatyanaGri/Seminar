/* Напишиет программу, которая принимает на вход число (А)
и выдает сумму чисел от 1 до А.

7 --> 28
4 --> 10 
8 --> 36

1.Получаем число с консоли
2.Считаем сумму чисел от 1 до введеного числа
3.Выводим сумму на экран

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

    return result;
}

int GetSum(int number)
{
    int sum = 0;
    
    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }

    return sum;
}

int number = GetNumber("Введиет число больше 1:");

int sum = GetSum (number);

Console.WriteLine($"Сумма чисел от 1 до {number} равна {sum}");

