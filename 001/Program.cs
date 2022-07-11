//Console.WriteLine(11%3);
// С клавиатуры вводится целое число. Вывести квадрат числа 

double a;
double b;
string? s = Console.ReadLine();
a =Convert.ToDouble(s);
b= a*a;
System.Console.WriteLine("{0}^2={1}", a,b); //строка форматирования
System.Console.WriteLine($"{a}^2={b}"); // строка интерполяции

/*
string? s;
s = Console.ReadLine();

System.Console.WriteLine(s);
*/