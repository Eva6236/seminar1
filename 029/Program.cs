//Подсчитать сумму цифр в числе
int a, b;
Console.Write("Введите число: ");
string? s = Console.ReadLine();
a = Convert.ToInt32(s);
b = 0;
while (a > 0){
    b = b + a % 10;
    a = a /10 ;
 }
 Console.WriteLine(b);