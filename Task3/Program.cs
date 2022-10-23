// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите день недели");
int day = Convert.ToInt32(Console.ReadLine());

if(day < 8 && day > 0)
{
    if (day == 6 | day == 7) Console.WriteLine($"{day} является выходным");
    else Console.WriteLine($"{day} не является выходым");
}
else Console.WriteLine("Такого дня недели не существует");


