﻿// Написать программу показывающие первые N чисел, для которых 
//каждое следующее равно сумме двух предыдущих. 
//Первые два элемента последовательности 0 и 1
int F(int N) {
    if(N==0) return 0;
    if (N==1) return 1;
    else return F(N-1)+F(N-2);
}
System.Console.WriteLine(F(7));