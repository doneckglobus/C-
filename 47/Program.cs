// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int check_num(string str)  
{ 
    int output_num; 
    Console.WriteLine(str);
    while(true) 
    { 
        string text = Console.ReadLine();
        if (int.TryParse(text, out output_num)) 
            return output_num; 
        else
            Console.Write("Нужно ввести число, а не строку: ");
    } 
}

double[,] give_me_matrix(int rows, int cols)
{
    double[,] matrix = new double[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
            { 
                matrix[i, j] = rand.Next(10) + Math.Round(rand.NextDouble(), 2);
            }  
    }
    return matrix;
}

void ShMeArray(double [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
}


int m = check_num("Введите количество строк: ");
int n = check_num("Введите количество столбцов: ");
ShMeArray(give_me_matrix(m, n));
