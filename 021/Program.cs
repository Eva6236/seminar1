//Задать номер четверти, показать диапазоны для возможных координат.
double a;
System.Console.WriteLine("Введите номер четверти: ");
string? s=Console.ReadLine();
a=Convert.ToDouble(s);
if (a == 1){
System.Console.WriteLine("Диапазон x > 0, y > 0 ");
}
if (a == 2){
System.Console.WriteLine("Диапазон x < 0, y > 0 ");
}
if (a == 3){
System.Console.WriteLine("Диапазон x < 0, y < 0 ");
}
if (a == 4){
System.Console.WriteLine("Диапазон x > 0, y < 0 ");
}
else{
    System.Console.WriteLine("Не верно введен номер четверти");
}