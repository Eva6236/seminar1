// Показать кубы чисел, заканчивающихся на четную цифру.
int N, i, multi;
Console.Write("Введите кол-во чисел: ");
string? s = Console.ReadLine();
N = Convert.ToInt32(s);
 
Console.WriteLine("Кубы чисел, оканчивающиеся на четную цифру: ");
for (i = 1; i <= N; i++) {
    multi = i*i*i;
    if((multi % 2) == 0) {
        System.Console.WriteLine(multi);
    }
}
