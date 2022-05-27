// Задача 64: Напишите программу, 
// которая будет принимать на вход число и возвращать сумму его цифр.

int sum = 0;
void SummOfNumbers(int num)
{
    if (num != 0)
    {
        sum += num % 10;
        num = num / 10;
        SummOfNumbers(num);
    }
    else System.Console.WriteLine(sum);
}

System.Console.Write("Введите любое натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

SummOfNumbers(number);