// Написать программу вычисления произведения чисел от 1 до N
int i, A; 
int multi = 1; 
Console.Write("Введите число: ");
string? s = Console.ReadLine();
A = Convert.ToInt32(s);
for (i=1; i <=A; i++) {
multi = multi  * i;
}
System.Console.WriteLine(multi);

