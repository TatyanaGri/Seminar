/*Задача №17. Напишите программу, которая принимает 
на вход координаты точки (X и Y), 
причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти 
плоскости, в которой находится эта точка.
|   | 2  |   |   y 1
------------------------->X
|   | 3  |   |     4

1.получить две координаты с консили
2.почлучить четверть
3.вывести на консоль результат*/

int GetNumber(string message)
{
    int resultNumber = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out resultNumber) && resultNumber != 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или не корректное число. Повторите ввод!\n");
        }
    }

    return resultNumber;
}

int GetQuarter(int x, int y)
{
    if(x > 0 && y > 0)
        return 1;
    else if(x < 0 && y > 0)
        return 2;
    else if(x < 0 && y < 0)
        return 3;
    else
        return 4;
}

int x = GetNumber("Введите координату Х, которая не равна 0:");
int y = GetNumber("Введите координату Y, которая не равна 0:");
int quarter = GetQuarter(x,y);

Console.WriteLine($"Точка с координатами ({x},{y}) лежит в {quarter} четверти");

/*
1.ссылочный тип данных (reference typec)

-хранятся в управляемой кучи
- классы, листы, массивы, char

2.значимый тип данных (values types)
- храниться в стеке оперативной памяти
- int, double, datetime, long, byte, float

3.string
на пересечении */