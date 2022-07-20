// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
Console.WriteLine("Введите размер массива: ");
int n=int.Parse(Console.ReadLine());
int [] a=new int[n];
Random random=new Random();
    for (int i = 0; i < n; i++)
        {
            a[i] = random.Next(0, 124);
        }
    for(int i = 0; i < n; i++)
System.Console.Write($"{a[i], 4}");
int count_1 = 0;
for(int i = 0; i < n; i++)
    if ((a[i] > 9 && a[i] < 100))
    {
        count_1 +=1; 
                    
    }
    System.Console.Write($"\nКоличество элементов {count_1}");