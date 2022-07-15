// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
double x,y ;
System.Console.WriteLine("Введите x: ");
string? s=Console.ReadLine();
x=Convert.ToDouble(s);
System.Console.WriteLine("Введите y: ");
string? e=Console.ReadLine();
y=Convert.ToDouble(e);
if (x > 0){
    if (y > 0)
         Console.WriteLine("I четверть");
    else if (y < 0)
        Console.WriteLine("IV четверть");
}
            
if (x < 0){
    if (y > 0)
        Console.WriteLine("II четверть");
    else if (y < 0)
        Console.WriteLine("III четверть");
}

