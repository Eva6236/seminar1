// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
Console.WriteLine("Введите размер массива: ");
int n=int.Parse(Console.ReadLine());
int [] a=new int[n];
Random random=new Random();
int count_1 = 0;
int count_2 = 0;
    for (int i = 0; i < n; i++)
        {
            a[i] = random.Next(100, 999);
System.Console.Write($"{a[i], 4}");
        }
    for(int i = 0; i < n; i++)
        {
         if ( i % 2 == 0)
            {
              count_1 +=1; 
                    
            }
        
        else{
            count_2 +=1;
        }
        }
Console.Write($"\nКоличество четных: {count_1}");
Console.Write($"\nКоличество нечетных: {count_2}");
        