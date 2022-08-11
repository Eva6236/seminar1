﻿// Показать двумерный массив размером m×n заполненный целыми случайными числами
int N=3;
int M=2;

int[,] a=new int[N,M];
//Инициализация случаными числами 
Random random=new Random();
for(int i=0;i<a.GetLength(0); i++) {
    for(int j=0;j<a.GetLength(1);j++) {
       a[i,j]=random.Next(1,11); 
    }
    
}
//вывод массива на экран
for(int i=0;i<a.GetLength(0); i++) {
    for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j]} ");
    System.Console.WriteLine();
}
