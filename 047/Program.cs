// Написать программу масштабирования фигуры.
int[] x=new int[4];
int[] y=new int[4];
x[0] = 0;
y[0] = 0;
x[1] = 2;
y[1] = 0;
x[2] = 2;
y[2] = 2;
x[3] = 0;
y[3] = 2;
int k = 2; 
Print();
for (int i = 0; i < 4; i++){
    x[i] = x[i] * k;
    y[i] = y[i] * k;
}
Print();
void Print(){
    for (int i = 0; i < 4; i++){
        Console.Write($"({x[i]}, {y[i]})");
    }
    Console.WriteLine();
}




