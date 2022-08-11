// Задача 41A
// Дана квадратная матрица. Проверить, является ли она симметричной относительно главной диагонали.
int[,] a;
a=Init(3,3);
Print(a);

bool check_symmetry = true;
for(int i = 0; i < a.GetLength(0); i++)
        for (int j = 0; j < a.GetLength(1); j++){
            if(a[i,j] != a[j, i])
                check_symmetry = false;
        }
        if(check_symmetry == true)
        System.Console.WriteLine("Матрица симметрична");
        else
        System.Console.WriteLine("Матрица не симметрична");





int[,] Init(int N,int M) {
a=new int[N,M];
    Random random=new Random();
        for(int i=0;i<a.GetLength(0); i++) {
            for(int j=0;j<a.GetLength(1);j++) {
            a[i,j]=random.Next(0,2); 
            }
    
        }
        return a;
}



void Print(int[,]a ) {
    for(int i=0;i<a.GetLength(0); i++) {
        for(int j=0;j<a.GetLength(1);j++)
            System.Console.Write($"{a[i,j], 3} ");
        System.Console.WriteLine();
    }
}
