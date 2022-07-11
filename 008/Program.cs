// Вывести на экран числа от -N до N
int N, N1; 
System.Console.WriteLine("Введите отрицательное число: ");
string? s=Console.ReadLine();
N = Convert.ToInt32(s); 
System.Console.WriteLine("Введите положительное число: ");
string? d=Console.ReadLine();
N1 = Convert.ToInt32(d); 
while(N<=N1)
{
    {
        System.Console.WriteLine( N );
    }
    N++;
}