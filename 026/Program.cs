// Найти сумму чисел от 1 до А. 
int i, A; 
int sum = 0; 
Console.Write("Введите число: ");
string? s = Console.ReadLine();
A = Convert.ToInt32(s);
for (i=1; i <=A; i++) {
sum = sum+i;
}
System.Console.WriteLine(sum);

