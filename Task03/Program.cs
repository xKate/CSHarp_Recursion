//Задайте произвольный массив. Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.

void Main()
{
    int sizeArray = ReadInt("Введите размер массива: ");

    int[] array = GenerateArray(sizeArray, 0, 20);
    PrintArray(array);
    Console.WriteLine();
    PrintArrInverted(array, array.Length - 1);
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
        tempArray[i] = rand.Next(leftRange, rightRange + 1);

    return tempArray;
}

void PrintArray(int[] arrayForPrint)
{
    System.Console.WriteLine("[ " + string.Join(", ", arrayForPrint) + " ]"); //  --------
}

void PrintArrInverted(int[] array, int i)
{
    if (i < 0)
        return;

    System.Console.Write(array[i] + " ");
    PrintArrInverted(array, i - 1);
}

Main();
