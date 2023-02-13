// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


int[,] give_me_matrix(int rows, int cols) // заполняю массив построчно
{
    int[,] matrix = new int[cols, rows];
    Random rand = new Random();
    for (int i = 0; i < cols; i++)
    {
        for (int j = 0; j < rows; j++)
            { 
                matrix[i, j] = rand.Next(0, 10);
            }  
    }
    return matrix;
}

void ShMeArray(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                Console.Write(matrix[j, i] + "\t");
            }
            Console.WriteLine();
        }
}


int[] Sum(int [,] matrix)
{
    int[] sum_array = new int[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
        {
            int sum = 0;
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
               sum = sum + matrix[j, i];
               sum_array[i] = sum;
            }
            
        }
    return sum_array;
}

void Shsum(int [] array)
{
    Console.WriteLine($"Сумма строк массива: ");    
    foreach(var c in array) 
        { 
            Console.Write(c + "\t");
        }
}

void SearchAndShowMinArray(int [] arr_sums)
{   
    int min = arr_sums.Min();
    for (int j = 0; j < arr_sums.Length; j++)
    {
        if (min == arr_sums[j])
            Console.WriteLine($"Сумма цифр стобца с индексом {j} меньше всего");
    }
}

int[,] arr = give_me_matrix(5, 3);
ShMeArray(arr);
int[] arr_sums = Sum(arr);
Shsum(arr_sums);
Console.WriteLine();
SearchAndShowMinArray(arr_sums);
