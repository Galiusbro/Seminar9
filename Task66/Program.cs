// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

int sum = 0;
void SummOfNumbers(int min, int max)
{
    if (min <= max)
    {
        sum += min;
        min++;
        SummOfNumbers(min, max);
    }
    else System.Console.WriteLine(sum);
}

System.Console.Write("Найдем сумму натуральных элементов от M: ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Найдем сумму натуральных элементов до N: ");
int n = Convert.ToInt32(Console.ReadLine());

SummOfNumbers(m, n);