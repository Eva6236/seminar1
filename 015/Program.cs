// С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет.
int a;
System.Console.WriteLine("Введите число: ");
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
if (s.Length >= 3 ) {
    int i = 3;
    int dd = 1;
    while (i < s.Length) {
        dd = dd * 10;
        i++;
    }
    System.Console.WriteLine((a / dd) % 10);
}
else {
    System.Console.WriteLine("Третьей цифры - нет");
}
