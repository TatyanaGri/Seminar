/* Задача 39: Напишите программу, которая перевернёт одномерный
 массив (последний элемент будет на первом месте, а первый - 
 на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]

1 инициализируем массив
2 печатаем массив
3 переворачиваем массив
4* попробуем решить все в одну строчку
*/

int[] InitArray(int dimension)

/* сначал идет перечисление переменных
пробел перед перечислением (for, for rich, while), т.е. все конструкции 
отделяем между собой.
дурной тон задавать переменные вне методов и много. забыть про это! 
переменная создается в методе, и для метода.
!! посмотреть как провильно формировать код по С#, прописывать все скрытые 
места */

// инициализируем массив

{
    int[] result = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        result[i] = rnd.Next(1,10);
    }

    return result;
}

// печатаем массив

void  PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//переворачиваем массив

int[] ReversArray(int[] array)
{
    int[] result = new int[array.Length];
    int count = 0;
    for (int i = array.Length - 1; i >= 0; i--)
    {
        result[count] = array[i];
        count++;
    }
   
    return result;
}

int[] startArray = InitArray(10);
PrintArray(startArray);

int[] resultArray = ReversArray(startArray);
PrintArray(resultArray);

Console.WriteLine();

int[] arrStart = Enumerable.Range(1,10).ToArray();
PrintArray(arrStart);

int[] arr = Enumerable.Range(1,10).Reverse().ToArray();
PrintArray(arr);

//Enumerable.Range(1,10) - просто перечисление
//Array.Reverse(arr) - переворачивает масси, можем в скобки вставить любой массив и сделать реверс
// или arr.Reverse()