//// Написать программу масштабирования фигуры. 
// Чтобы задавались вершины фигуры списком (одной строкой), например "(0,0) (2,0) (2,2) (0,2)"
// Коэффициент масштабирования задавался отдельно - 2 или 4 или 0.5
// В результате показать координаты, которые получатся. 
void FillMatrix (double[,] matrix, int min, int max)
{
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)       
        matrix[i,j] = random.Next(min, max);
}

void PrintMatrix (double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
       Console.Write($"({matrix[i,0]}; {matrix[i,1]}) ");
       Console.WriteLine();
}

void ScalingMatrix(double[,] matrix, double k)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
           matrix[i,j] = matrix[i,j] * k;    
}

double [,] matrix = new double [4,2];
Console.WriteLine("Коориднаты исходной фигуры: ");
FillMatrix(matrix, -10, 10);
PrintMatrix(matrix);
Console.WriteLine("Введите коэффициент масштабирования k");
double k = double.Parse (Console.ReadLine() ?? "0");
Console.WriteLine("Координаты фигуры после масштаирования: ");
ScalingMatrix(matrix, k);
PrintMatrix(matrix);