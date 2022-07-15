// Программа проверяет пятизначное число на палиндромом.
int a, b, c, d;
System.Console.WriteLine("Введите пятизначное число: ");
string? s=Console.ReadLine();
a = Convert.ToInt32(s);
b = 0; 
d = a;
while (d > 0){
    c = d % 10;
    b = b * 10 + c;  
    d = d / 10; 
}
if(a == b){
        System.Console.WriteLine("Число - палиндром");
}
    else{
        System.Console.WriteLine("Число не палиндром");
}
 

