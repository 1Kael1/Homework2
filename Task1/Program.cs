// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Выполнить с помощью числовых операций.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int Digit(int num1) 
{
    int digit1 = num1 / 100; 
    int digit2 = num1 / 10;
    return  digit2 - digit1 * 10;
}
Console.WriteLine($"{Digit(num)}");  