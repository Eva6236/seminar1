// По двум заданным числам проверять является ли одно квадратом другого.
//Используйте подпрограмму.

bool Check(int a, int b)
{
    return a*a==b; // подпрограмма не выводит ничего на экран! 
}
int a,b;
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
s=Console.ReadLine();
b=Convert.ToInt32(s);
// ==, !=,>,<, >=,<=

if(Check (a,b))
{
    System.Console.WriteLine("b является квадратом а");
}
else
{
    if (Check(b,a))
    {
    System.Console.WriteLine("а является квадратом b");
    }
    else
    {
        System.Console.WriteLine("Числа не являются квадратами друг друга");
    }
}

