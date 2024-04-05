//Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

void Main()
{
    int n = ReadInt("Введите неотрицательное число n: ");
    int m = ReadInt("Введите неотрицательное число m: ");

    Console.WriteLine(Akkerman(n, m));

    static extern int Akkerman(int n, int m);
    {
        if (m == 0)
        {
            return (n + 1);
        }
        else if (m > 0 && n == 0)
        {
            return Akkerman(m - 1, 1);
        }
        else if (m > 0 && n > 0)
        {
            return Akkerman(m - 1, Akkerman(m, n - 1));
        }
    }

    int ReadInt(string msg)
    {
        System.Console.Write(msg);
        return Convert.ToInt32(Console.ReadLine());
    }
}
Main();
