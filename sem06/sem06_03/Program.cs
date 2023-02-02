/* Задача 42: Напишите программу, которая будет преобразовывать десятичное 
число в двоичное.
45 -> 101101
3 -> 11
2 -> 10

1 рандомно получаем число
2 создаем массив для хранения остатка от деения на 2
3 в цикле делим на 2 и записываем остаток в массив, поочередно пока не закончится массив
4 переворачиваем массив
5 выводим массив
*/

Random random = new Random();
int number = random.Next();
Console.WriteLine($"Рандомное число равно {number}");

string number_str = " ";

while (number > 0)
{
    number_str = number_str + number % 2;
    number = number / 2;
}

string result = new string(number_str.Reverse().ToArray()); // тут мы указываем, создаем новую строку, берем полученные данные и переворачиваем их в массиве
Console.WriteLine($"Двоичная форма полученного числа равна: {result}");


/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

string number_str = " ";

while (number > 0)
{
    number_str = number_str + number % 2 ;
    number = number / 2 ;
}

string result = new string(number_str.Reverse().ToArray());
Console.WriteLine($"Двоичная форма введенного числа равна: {result}");
*/