// По заданному с клавиатуры номеру дня недели вывести его название
int x; 
System.Console.WriteLine("Введите номер дня недели: ");
string? s = Console.ReadLine();
x = Convert.ToInt32(s);

switch (x)
{
    case 1:
    Console.WriteLine("Понедельник"); 
        break;   
    case 2:     
    Console.WriteLine("Вторник");     
        break ;     
    case 3:     
    Console.WriteLine("Среда");    
        break;  
    case 4:     
    Console.WriteLine("Четверг");      
        break;     
    case 5:     Console.WriteLine("Пятница");     
        break;  
    case 6:     Console.WriteLine("Суббота");    
        break;   
    case 7:     Console.WriteLine("Воскресенье");     
        break;    
    default:      Console.WriteLine("Неверно введный номер дня");   
        break; 
}


/*
while (x => 7)
{
    if (x = 1)
    {
        System.Console.WriteLine("Понедельник");
    }
    
    if (x = 2)
    {
        System.Console.WriteLine("Вторник");
    }
    
    if (x = 3)
    {
        System.Console.WriteLine("Среда");
    }
    
    if (x = 4)
    {
        System.Console.WriteLine("Четверг");
    }
    
    if (x = 5)
    {
        System.Console.WriteLine("Пятница");
    }
    
    if (x = 6)
    {
        System.Console.WriteLine("Суббота");
    }
    

    if (x = 7)
    {
        System.Console.WriteLine("Воскресение");
    }
else 
{
    System.Console.WriteLine("Неверно введенный номер дня");
}
}   
  */  
