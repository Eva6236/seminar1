// Проверить истинность утверждения !(X || Y)==!X and !Y
//System.Console.WriteLine($ воспринимается как переменная{})

/*int N=5;
bool x,y,f1, f2; 
x=false;
y=false;
f1 = ! (x|| y);
f2 = !x && !y;
System.Console.WriteLine($"{x} {y} {f1} {f2}");
//F = ! (X || Y) == !X && !Y;
//System.Console.WriteLine($"{X} {Y} {F}");
*/

int N=5;
System.Console.WriteLine($"N={N}");
bool x,y,f1,f2;
x=true;
y=true;
f1=!(x || y);
f2=!x && !y;
System.Console.WriteLine($"{x} {y} {f1} {f2}");
