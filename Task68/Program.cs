// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа n и m.

int Akkerman(int m, int n)
{
    if (m == 0)
        return (n + 1);
    else
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    return Akkerman(m - 1, Akkerman(m, n - 1));
}

System.Console.Write("Введите неотрицательное число M: ");
int m = int.Parse(Console.ReadLine());

System.Console.Write("Введите неотрицательное число N: ");
int n = int.Parse(Console.ReadLine());

System.Console.WriteLine(Akkerman(m, n));