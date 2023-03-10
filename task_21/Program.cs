// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


double Distance3D(double Ax, double Ay, double Az, double Bx, double By, double Bz)
{
    double result = Math.Sqrt(Math.Pow(Ax - Bx, 2) + Math.Pow(Ay - By, 2) + Math.Pow(Az - Bz, 2));
    return Math.Round(result, 2);
}
Console.Write("Введите координату X точки A: ");
double Ax = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y точки A: ");
double Ay = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z точки A: ");
double Az = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату X точки B: ");
double Bx = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y точки B: ");
double By = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z точки B: ");
double Bz = Convert.ToDouble(Console.ReadLine());
double result = Distance3D( Ax, Ay, Az, Bx, By, Bz);
Console.WriteLine(result);

