//Определить сколько чисел больше 0 введено с клавиатуры.
Console.WriteLine("Введите размер массива: ");
int n=int.Parse(Console.ReadLine());
int [] a=new int[n];
Random random=new Random();
    for (int i = 0; i < n; i++) {
            a[i] = random.Next(-20, 21);
            System.Console.Write($"{a[i], 4}");
        }
int moreZero = 0;
for (int i = 0; i < a.Length; i++ )
    if (zero(a[i])) {
        moreZero++;
    }
System.Console.WriteLine($"\nКоличество чисел больше 0: {moreZero}" );
bool zero(int val) { 
    return val > 0 ? true : false;
}