//Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 
System.Console.WriteLine("Введите число: ");
int n, y;
string? s=Console.ReadLine();
n = Convert.ToInt32(s); 
y = n % 10;
Console.WriteLine($"Последняя цифра числа - { y }");
 