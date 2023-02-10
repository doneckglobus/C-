// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


int[,] give_me_matrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
            { 
                matrix[i, j] = rand.Next(0, 10);
            }  
    }
    return matrix;
}

void ShMeArray(int [,] matrix)
{
    Console.WriteLine("Так как данный двумерный массив сначала формирует столбцы, то ");
    Console.WriteLine("выводиые строки на самом деле являются стобцами ");
    for (int i = 0; i < matrix.GetLength(0); i++)  
        {
            double sum = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
                sum = sum + matrix[i, j];
            }
            Console.WriteLine();
            Console.WriteLine($"Среднее арифметическое стобца: {Math.Round(sum/matrix.GetLength(1), 2)}");
            Console.WriteLine();
        }
}

ShMeArray(give_me_matrix(3, 4));
