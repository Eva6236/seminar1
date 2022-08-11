// Задача 42A
//Даны две квадратных таблицы чисел. Требуется построить третью, каждый элемент которой равен сумме элементов, стоящих на том же месте в 1-й и 2-й таблицах.
int N = 3;
int M = 3;

int[,] a;
a = Init(3, 3);
Print(a);
System.Console.WriteLine();
int[,] b;
b = Init2(3, 3);
Print2(b);
System.Console.WriteLine();
//решение
int[,] c = new int[N, M];
for (int i = 0; i < c.GetLength(0); i++)
{
    for (int j = 0; j < c.GetLength(1); j++)
    {
        c[i, j] = a[i, j] + b[i, j];
    }

}
System.Console.WriteLine("Сумма двух матриц");
Print3(c);













int[,] Init(int N, int M)
{
    a = new int[N, M];
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = random.Next(1, 101);
        }

    }
    return a;
}

int[,] Init2(int N, int M)
{
    b = new int[N, M];
    Random random = new Random();
    for (int i = 0; i < b.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            b[i, j] = random.Next(1, 101);
        }

    }
    return b;
}



void Print(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
            System.Console.Write($"{a[i, j],3} ");
        System.Console.WriteLine();
    }
}


void Print2(int[,] b)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
            System.Console.Write($"{b[i, j],3} ");
        System.Console.WriteLine();
    }
}

void Print3(int[,] c)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
            System.Console.Write($"{c[i, j],3} ");
        System.Console.WriteLine();
    }
}

/*void Solution(int[,] c)

for(int i=0;i<c.GetLength(0); i++) {
    for(int j=0;j<c.GetLength(1);j++) {
       c[i,j]=a[i,j]+b[i,j]; 
    }
    
}
*/