// Console.Clear();
// Console.WriteLine("Task 47");
// Console.WriteLine("------");

// void InputMatrixDouble(double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = Math.Round(new Random().NextDouble()*20-10,2);
//     }
// }

// void PrintMatrixDouble(double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write($"{matrix[i, j]} \t");
//         Console.WriteLine();
//     }
// }

// Console.Write("Введите размер массива: ");
// int[] size1 = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
// double[,] matrixDouble = new double[size1[0], size1[1]];
// InputMatrixDouble(matrixDouble);
// PrintMatrixDouble(matrixDouble);

// Console.ReadLine();

// /*--------------------------------------------*/

// Console.Clear();
// Console.WriteLine("Task 50");
// Console.WriteLine("------");

// void InputMatrixInt1(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = new Random().Next(1,10);
//     }
// }

// void PrintMatrixInt1(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write($"{matrix[i, j]} \t");
//         Console.WriteLine();
//     }
// }

// Console.Write("Введите размер массива: ");
// int[] size2 = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
// int[,] matrix1 = new int[size2[0], size2[1]];
// InputMatrixInt1(matrix1);
// PrintMatrixInt1(matrix1);

// Console.Write("Введите позицию массива: ");
// int[] pos = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

// if(pos[0]<matrix1.GetLength(0) && pos[1]<matrix1.GetLength(1))
//     Console.WriteLine($"На данной позиции элемент: {matrix1[pos[0],pos[1]]}");
// else Console.WriteLine("Такой позиции нет");

// Console.ReadLine();

// /*--------------------------------------------*/

Console.Clear();
Console.WriteLine("Task 52");
Console.WriteLine("------");

void InputMatrixInt2(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1,10);
    }
}

void PrintMatrixInt2(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

void ArithMean(int [,] matrix){
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double arith = 0;
        for (int j = 0; j < matrix.GetLength(0); j++){
            arith += (double)matrix[j,i]/matrix.GetLength(0);
        }
        Console.Write($"{Math.Round(arith,1)} ");    
    }
}

Console.Write("Введите размер массива: ");
int[] size3 = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix2 = new int[size3[0], size3[1]];
InputMatrixInt2(matrix2);
PrintMatrixInt2(matrix2);
ArithMean(matrix2);

Console.ReadLine();

/*--------------------------------------------*/