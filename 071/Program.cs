﻿// Написать программу вычисления функции Аккермана
int A(int m, int n)
{
    if (m == 0) return n + 1;
    else if ((m > 0) && (n == 0)) return A(m - 1, 1);
    else
        return A(m - 1, A(m, n - 1));
}

System.Console.WriteLine(A(4,0));
