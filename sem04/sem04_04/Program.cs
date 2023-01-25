/* Задача 30: Напишите программу, которая 
выводит массив из 8 элементов, заполненный нулями и 
единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/

int[] GreatArray()
{
    int[] array = new int [8];
    Random number = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = number.Next(0,2);
    }
    return array;
}

int[] num = GreatArray();

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
       Console.Write($"{array[i]} "); 
    } 
}

PrintArray(num);

/*
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0,2);
        index ++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position ++;
    }
}

int[] array = new int[8];

FillArray(array);
PrintArray(array);
*/