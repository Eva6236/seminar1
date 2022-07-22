// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
double b1, k1, b2, k2, x, y;
System.Console.WriteLine("Введите b1: ");
string? a = Console.ReadLine();
b1 = Convert.ToInt32(a);

System.Console.WriteLine("Введите k1: ");
string? b = Console.ReadLine();
k1 = Convert.ToInt32(b);

System.Console.WriteLine("Введите b2: ");
string? c = Console.ReadLine();
b2 = Convert.ToInt32(c);

System.Console.WriteLine("Введите k2: ");
string? d = Console.ReadLine();
k2 = Convert.ToInt32(d);
void Solve1() {
System.Console.WriteLine(x = (b1-b2)/(k2-k1));
}
void Solve2() {
System.Console.WriteLine(y = (k2*b1-k1*b2)/(k2-k1));
}
Solve1();
Solve2();