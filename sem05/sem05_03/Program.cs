/* Задача 33: Задайте массив. Напишите программу, которая 
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

int[] IntArray(int dimension)
{
    int[] arr = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        arr[i] = rnd.Next(-1000,1000);
    }

    return arr;
}

bool FindNumber(int find, int[] arr)
{
    bool result = false;
    for (int i = 0; i < arr.Length; i++)
    {
        if (find == arr[i])
        {    result = true;
            break;
        }
    }
    return result;
}

int[] arr = IntArray(10);
Console.WriteLine(string.Join(", ", arr));
Console.WriteLine("Введите число для поиска: ");
int find = Convert.ToInt32(Console.ReadLine());
bool a = FindNumber(find, arr);

if (a) Console.WriteLine("Элемент найден");
else Console.WriteLine("Элемент не найден");
