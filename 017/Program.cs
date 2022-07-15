// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

int x;
System.Console.WriteLine("Введите день недели: ");
string? s=Console.ReadLine();
x = Convert.ToInt32(s);

bool b = (x == 6 | x == 7);

if (b) {
    System.Console.WriteLine("Выходной день!!! ");
 } else {
    System.Console.WriteLine("Будний день");
}
/*if (x > 7){
     System.Console.WriteLine("Неверно введненный день");
}
*/


















/*int [] x; 
System.Console.WriteLine("Введите номер дня недели: ");
string? s=Console.ReadLine();
x = Convert.ToInt32(s); 
array[1, 2, 3, 4, 5, 6, 7];
if (x = array [1 - 5]) 
{
    System.Console.WriteLine("Рабочий день");
}
else 
    System.Console.WriteLine("Выходной день");
*/

   
 