// Написать программу замены элементов массива на противоположные
Console.WriteLine("Введите размер массива: ");
int n=int.Parse(Console.ReadLine());
int [] a=new int[n];
Random random=new Random();
    for (int i = 0; i < n; i++) 
      {
    a[i] = random.Next(-10, 10);
}
    for(int i = 0; i < a.Length; i++)
System.Console.Write($"{a[i], 4}");
 
for (int i = 0;i < n; i++) {
      a[i] =  -1 * a[i];
}
for (int i = 0;i < n; i++) {
System.Console.Write($"\n{a[i], 4} ");
}
      

