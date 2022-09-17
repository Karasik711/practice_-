// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введи 2 числа и мы тебе скажем какое из них больше, а какое меньше");
int a, b;
Console.WriteLine("Введи свое первое число - ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи свое второе число - ");
b = Convert.ToInt32(Console.ReadLine());
 
bool num0 = a > b;
bool num1 = a == b;
bool num2 = a < b;
 
     if (num0)
        {
            Console.WriteLine($"Число {a} больше чем {b}, а число {b} меньше чем {a}");
         }
         else if (num1)
         {
             Console.WriteLine($"Числа {a} и {b} равны");
         }
         else if (num2)
         {
            Console.WriteLine($"Число {b} больше чем {a}, а число {a} меньше чем {b}");
         }