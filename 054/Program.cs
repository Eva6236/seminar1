// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
int[,] a;
a = Init(3, 4);
Print(a);
System.Console.WriteLine();
OrderArrayLines(a);
Print(a);











void OrderArrayLines(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            for (int k = 0; k < a.GetLength(1) - 1; k++)
            {
                if (a[i, k] < a[i, k + 1])
                {
                    int temp = a[i, k + 1];
                    a[i, k + 1] = a[i, k];
                    a[i, k] = temp;
                }
            }
        }
    }
}


int[,] Init(int N, int M)
{
    a = new int[N, M];

    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = random.Next(1, 10);
        }

    }
    return a;
}


void Print(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
            System.Console.Write($"{a[i, j],2} ");
        System.Console.WriteLine();
    }
}
