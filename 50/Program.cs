//Задача 50. Напишите программу, которая на вход принимает число,
 //возвращает индексы этого элемента в двумерном массиве или же указание, что такого числа нет.

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
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
}

void ShIndexes(int [,] matrix, int num)
{
    int noindex = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (num == matrix[i, j])
                {
                    Console.Write($"[{j}, {i}]; ");
                    noindex++;
                }
            }
            Console.WriteLine();
        }
    if (noindex == 0)
        Console.Write("Такого числа нет.");
        
}


int [,] arr = give_me_matrix(4, 4);
ShMeArray(arr);
int i = check_num("Введите индекс: ");
ShIndexes(arr, i);