// Задача 10: Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
// Первый вариант решения

Console.WriteLine("Введи трехзначное число : ");
int a = Convert.ToInt32(Console.ReadLine());
int firstDigit = a / 100;
int secondDigit = a % 100 / 10;
int thirdDigit = a % 10;
Console.WriteLine($"вторая цифра этого числа {secondDigit}");

// Втрой вариант решения.

//  Console.Write("Введи трёхзначное число: ");
//  int a = Convert.ToInt32(Console.ReadLine());
//  string Number = Convert.ToString(a);
//  Console.WriteLine("вторая цифра этого числа "+Number[1]);