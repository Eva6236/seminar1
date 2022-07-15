// Найти расстояние между точками в пространстве 2D
//теорема пифагора
double x1, x2, y1, y2;
System.Console.WriteLine("Введите x1: ");
string? s=Console.ReadLine();
x1=Convert.ToInt32(s);

System.Console.WriteLine("Введите x2: ");
string? e=Console.ReadLine();
x2=Convert.ToInt32(e);

System.Console.WriteLine("Введите y1: ");
string? d=Console.ReadLine();
y1=Convert.ToInt32(d);

System.Console.WriteLine("Введите y2: ");
string? t=Console.ReadLine();
y2=Convert.ToInt32(t);
double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine($"Расстояние между двумя точками на плоскости равно {distance}");