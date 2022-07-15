// Возведите число А в натуральную степень B используя цикл
/*int a, b, c;
Console.Write("Введите число: ");
string? s = Console.ReadLine();
a = Convert.ToInt32(s);
Console.Write("Введите степень: ");
string? e = Console.ReadLine();
b = Convert.ToInt32(e);
c = Math.Pow(a, b);
System.Console.WriteLine(c);
*/
int a, b, i, c;
Console.Write("Введите число: ");
string? s = Console.ReadLine();
a = Convert.ToInt32(s);
Console.Write("Введите степень: ");
string? e = Console.ReadLine();
b = Convert.ToInt32(e);
 c = 1;
for(i=1;i<=b;i++)
{
    c *= a;
}
System.Console.WriteLine(c);

