//Дано число. Проверить кратно ли оно 7 и 23
/*
bool b, c;//true false
b=false;
b=true;
b=2*2<5;
int x=14;
b=x%7==0;
System.Console.WriteLine(b);
*/

bool b,c, d;
int x=23*14;
b=x%7==0; //простое или элементарное
c=x%23==0;
d=b && c; //&&-and, сложное условие
System.Console.WriteLine(x);
/*
System.Console.WriteLine(b);
System.Console.WriteLine(c);
System.Console.WriteLine(d);
*/
//System.Console.WriteLine(x%7==0 && x%23==0);

if (d)
{
    System.Console.WriteLine($"{x} кратно 7 и 23");
}
else 
{
    System.Console.WriteLine($"{x} не кратно 7 и 23");
}
// | (|| лучше )- или ^ исключающее или, & (лучше &&)- и, ! - не 