// Удалить вторую цифру целого числа введенного с клавиатуры.
int a, b, c;
System.Console.WriteLine("Введите число: ");
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
if ( (a > 10) && (a < 100) ){
    b = a/10;
    System.Console.WriteLine(b);
}
if ((a > 100) && (a < 1000)){
    b=a%10;
    c=a/100; 
    System.Console.WriteLine($"{c}{b}");
}
if ((a > 1000) && (a < 10000)){
    b=a%100;
    c=a/1000; 
    System.Console.WriteLine($"{c}{b}");
}

/*
if ( (s.Length == 2) ){
    b = a/10;
    System.Console.WriteLine(b);
}

if ( (s.Length == 3) ){
    b=a%10;
    c=a/100; 
        System.Console.WriteLine($"{c}{b}");
        
}
*/