// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
void CubTab(int a)
{
    int count = 1;
    while (count <= a)
    {
        Console.WriteLine($"{count} {count * count * count}");
        count++;
    }
}
if (num > 0) CubTab(num);
else Console.WriteLine(" Введено некоректное значение");