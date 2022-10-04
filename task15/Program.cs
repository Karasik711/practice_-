// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndInt(int size, int min, int max)
{
    double[] array = new double[size];
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1, MidpointRounding.ToZero);
    }
    return array;
}
void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}; ");
        else Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}
double Difference(double[] array)
{
    double imin = array[0];
    double imax = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > imax) imax = array[i];
        if (array[i] < imin) imin = array[i];
    }
    double diff = imax - imin;
    return diff;
}

double[] arr = CreateArrayRndInt(10, 0, 100);
PrintArray(arr);
double difference = Difference(arr);
Console.WriteLine($"-> {difference}");