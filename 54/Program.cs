//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void sort_array(int [] array)
// Украл с гугла сортировку. Не хотелось лепить массив в массиве, если С# обладает собственными методами.
{
    var orderedNumbers = from i in array
                     orderby i descending
                     select i;
    
    foreach (int i in orderedNumbers)
        Console.Write(i+"\t");
        Console.WriteLine("");
}

int[,] give_me_matrix(int rows, int cols)
// Каюсь, здесь не только создание двумерки, но удобно именно здесь отдать temp_array на внешнюю обработку
{
    int[,] matrix = new int[rows, cols];
    Random rand = new Random();
    Console.WriteLine("Отсортированный массив: ");
    for (int i = 0; i < rows; i++)
    {
        int[] temp_array = new int[cols];
        for (int j = 0; j < cols; j++)
            { 
                int a = rand.Next(0, 10);
                matrix[i, j] = a;
                temp_array[j] = a;
            }
        sort_array(temp_array);
    }    
    return matrix;
}


void ShMeArray(int [,] matrix)
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

   
int[,] arr = give_me_matrix(5, 3);
Console.WriteLine("Оригинальный массив: ");
ShMeArray(arr);


