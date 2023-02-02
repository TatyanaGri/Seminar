/* Задача 40: Напишите программу, которая принимает на вход три числа и 
проверяет, может ли существовать треугольник с сторонами такой длины.

Теорема о неравенстве треугольника: каждая сторона треугольника 
меньше суммы двух других сторон
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

int numberA = GetNumber("Введите первое число:");
int numberB = GetNumber("Введите второе число:");
int numberC = GetNumber("Введите третье число:");

if (numberA < numberB + numberC && numberB < numberA + numberC && numberC < numberA + numberB)
{
    Console.WriteLine("Треугольник существует!");
}
else
{
    Console.WriteLine("Треугольник не может существовать!");
}





