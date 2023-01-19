/* Принимает число N, а на выходе показывает все целые числа
4 -> -4, -3, -2, -1, 0, 1, 2, 3, 4
*/

Console.WriteLine("Напишите число");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);

for (int i = - number; i <= number; i++)
{
    Console.Write(i + " ");
}