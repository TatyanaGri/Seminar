/* Задача 45: Напишите программу, которая будет создавать копию 
заданного массива с помощью поэлементного копирования.
*/

int[] InitArray(int dimension)
{
    int[] result = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        result[i] = rnd.Next(1,10);
    }

    return result;
}

int[] CopyArray(int [] start)
{
  int [] arr = new int[start.Length];
  for (int i = 0; i < start.Length; i++)
  {
    arr[i] = start[i];
  }
  return arr;
}

int [] start = InitArray(6);
Console.WriteLine("[{0}]",string.Join(", ", start));
Console.WriteLine(" ");
int [] arr = CopyArray(start);
Console.WriteLine("[{0}]",string.Join(", ", arr));


