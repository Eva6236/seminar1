﻿// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Write("Введи n: ");
int n = Convert.ToInt16(Console.ReadLine());
Console.Write("Введи m: ");
int m = Convert.ToInt16(Console.ReadLine());
int temp = m;

if (m > n) 
{
  m = n; 
  n = temp;
}

PrintSumm(m, n, temp=0);





void PrintSumm(int m, int n, int sum)
{
  sum = sum + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов = {sum} ");
    return;
  }
  PrintSumm(m, n - 1, sum);
}