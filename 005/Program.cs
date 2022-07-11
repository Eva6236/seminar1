//// С клавиатуры вводятся три числа. Найти максимальное из трех чисел.
int a,b,c;
System.Console.WriteLine("Введите первое число: ");
string? s;
s=Console.ReadLine();
a=Convert.ToInt32(s);
System.Console.WriteLine("Введите второе число: ");
s=Console.ReadLine();
b=Convert.ToInt32(s);
System.Console.WriteLine("Введите третье число: ");
s=Console.ReadLine();
c=Convert.ToInt32(s);
int max = a;
if (b > a)
    max = b;
if (c > max)
    max = c;
    System.Console.WriteLine($"Максимальное число - {max}");
