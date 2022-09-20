// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введи число : ");
// int a = Convert.ToInt32(Console.ReadLine());
// int firstDigit = a / 100;
// int secondDigit = a % 100 / 10;
// int thirdDigit = a % 10;
// Console.WriteLine($"третья цифра этого числа {thirdDigit}");

Console.Write("Введи число: ");
int Number = Convert.ToInt32(Console.ReadLine());
string NumberText = Convert.ToString(Number);
if (NumberText.Length > 2)
{
    Console.WriteLine("третья цифра " + NumberText[2]);
}
else
{
    Console.WriteLine("третьей цифры нет");
}