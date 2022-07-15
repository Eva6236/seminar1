// Вывести на экран кубы чисел от 1 до N.
int N, i;
Console.Write("Введите кол-во чисел: ");
string? s = Console.ReadLine();
N = Convert.ToInt32(s);
 
Console.WriteLine("Кубы чисел: ");
 for(i = 1; i <= N; i++)
Console.WriteLine(i*i*i);
