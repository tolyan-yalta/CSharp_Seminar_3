// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
Console.Clear();

Console.WriteLine("Введите координаты первой точки: ");

double[] point1 = new double[3];

Console.Write("x1 = "); 
point1[0] = Convert.ToDouble(Console.ReadLine());
Console.Write("y1 = ");
point1[1] = Convert.ToDouble(Console.ReadLine());
Console.Write("z1 = ");
point1[2] = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки: ");

double[] point2 = new double[3];

Console.Write("x2 = "); 
point2[0] = Convert.ToDouble(Console.ReadLine());
Console.Write("y2 = ");
point2[1] = Convert.ToDouble(Console.ReadLine());
Console.Write("z2 = ");
point2[2] = Convert.ToDouble(Console.ReadLine());

double result = Math.Sqrt(
Math.Pow((point1[0] - point2[0]), 2) +
Math.Pow((point1[1] - point2[1]), 2) + 
Math.Pow((point1[2] - point2[2]), 2)); 

Console.Write("Расстояние между точками = ");
Console.Write("{0:F2}", result);
