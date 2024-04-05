// Задайте значения M и N. Напишите программу,
//которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

void Main()
{
    int M = ReadInt("Введите число M: ");
    int N = ReadInt("Введите число N: ");
    
    if (M > N)
    {
        System.Console.WriteLine("Вы ввели некорректные значения!");
    }
    PrintNumbers(N, M);
}
void PrintNumbers(int N, int M)
{
    if (N < M)
        return;
    PrintNumbers(N - 1, M);
    System.Console.Write(N + " ");
}
int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
Main();
