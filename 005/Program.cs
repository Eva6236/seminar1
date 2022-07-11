// С клавиатуры вводятся три числа. Найти максимальное из трех чисел.
int a,b,c;
string? s;
s=Console.ReadLine();
a=Convert.ToInt32(s);
s=Console.ReadLine();
b=Convert.ToInt32(s);
s=Console.ReadLine();
c=Convert.ToInt32(s);
int max = a;
if (b > a)
    max = b;
if (c > max)
    max = c;
    System.Console.WriteLine(max);