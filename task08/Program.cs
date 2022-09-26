// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите х1 ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите y1 ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите c1 ");
int c1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите x2 ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите y2 ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите c2 ");
int c2 = Convert.ToInt32(Console.ReadLine());

double Distan( int argX1 , int argY1, int argC1, int argX2, int argY2, int argC2 )
{
    double resault = Math.Sqrt(Math.Pow((argX2 - argX1 ),2)+Math.Pow((argY2 -argY1),2)+Math.Pow((argC2 -argC1),2));
    return resault ;
}
double distance = Distan(x1,y1,c1,x2,y2,c2);
Console.WriteLine(Math.Round(distance,2, MidpointRounding.ToZero));