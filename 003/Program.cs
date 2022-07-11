// С клавиатуры вводятся два числа a и b. Найти максимальное из них.
int a,b; 

System.Console.WriteLine("Введите первое число: ");
string? s = Console.ReadLine();
a = Convert.ToInt32(s);
System.Console.WriteLine("Введите второе число: ");
string? e =Console.ReadLine();
b = Convert.ToInt32(e);
if (a > b)
{
    System.Console.WriteLine("первое - максимальное число");
}
else 
{
    System.Console.WriteLine("второе - максимальное число");
}
    
