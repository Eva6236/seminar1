// Выяснить является ли число чётным.
int a;
//int b;
int d = 2;
System.Console.WriteLine("Введите число: ");
string? s = Console.ReadLine();
a = Convert.ToInt32(s);
//b = a % d; 
//System.Console.WriteLine($"b = {b}");
if (a % d != 0) 
{
    System.Console.WriteLine("Нечетное число ");
} else 
{ 
    System.Console.WriteLine("Четное число ");
}
