// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
Console.WriteLine("Введите размер массива: ");
int n=int.Parse(Console.ReadLine());
int [] a=new int[n];
Random random=new Random();
int min = 100;
int max = 0;
    for (int i = 0; i < n; i++)
        {
            a[i] = random.Next(0, 101);
            System.Console.Write($"{a[i], 4}");
        }
for(int i = 0; i < n; i++){
    if (a[i] > max) max = a[i];
    if (a[i] < min) min = a[i];
}
System.Console.WriteLine();
System.Console.WriteLine($"Максимальное число: {max}");
System.Console.WriteLine($"Минимальное число: {min}");
Console.WriteLine("Разница максимального и минимального:  "+ (max - min));