//Найти расстояние между точками в пространстве 2D
Console.WriteLine("Введите координаты первой точки x1 и y1");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки x2 и y2");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Расстояние между точками = " + 
Math.Round(Match.Sqrt(Match.Pow(Match.Abs(x2-x2), 2) 
+ Match.Pow(Match.Abs(y2-y1), 2)), 2));
