// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int[,] a;
a = Init(4, 4);
Print(a);

int sum = 0, sum1 = 0, sum2 = 0, index = 0;
for (int i = 0; i < 4; i++) //Проходим по циклу строк
{
    sum2 = 0;
    for (int j = 0; j < 4; j++) //Проходим по циклу столбцов
    { sum2 += a[i, j]; } //Сумма всех членов 1ой строки.
    if (sum2 < sum1)
    {
        sum = sum2; index = i + 1;
    }
    sum1 = sum2;
}
Console.WriteLine("Наименьшаяя сумма = {0}", sum);
Console.WriteLine("Номер строки = {0}", index);





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
