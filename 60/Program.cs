// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


// int[] give_me_unique_random(int rows, int cols, int vol)
// {

//     int array_size = rows*cols*vol;
//     while (true)
//             {
//                 Random rand = new Random();
//                 int[] matrix = new int[array_size];
                
//                      for (int i = 0; i < array_size; i++)
//                      {
//                         int n = rand.Next(0, 99);
//                         if (matrix[i] == n)
//                             i--;
//                             break;
//                         else
//                             return n;
//                      }
//             }
// } 
//     for (int i = 0; i < array_size; i++)
//         {
//             matrix[i] = rand.Next(0, 99);
//         }
// }  

// int[] give_me_unique_random(int rows, int cols, int vol, int index)
// {
//     int array_size = rows*cols*vol;
//     int[] matrix = new int[array_size];
//     for (int i = 10; i < array_size; i++)
//     {
//         matrix[i] = i;
//     }
//     return matrix[i];
// }

    
    


int[,,] give_me_and_show_3d_matrix(int rows, int cols, int vol)
{
    int[,,] matrix = new int[rows, cols, vol];
    int[] unique_num = new int[rows*cols*vol];
    int g = 10;
    for (int d = 0; d < unique_num.Length; d++)
    {
        unique_num[d] = g;
        g++;
    }
    g = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
            { 
                for (int v = 0; v < vol; v++)
                {
                    matrix[i, j, v] = unique_num[g];
                    //System.Console.WriteLine($"Элемент массива {unique_num[g]} имеет координаты: {i}:{j}:{v}");
                    System.Console.Write($"{unique_num[g]}-{i}:{j}:{v};\t");
                    g++;
                }
            }  
    }
    return matrix;
}

give_me_and_show_3d_matrix(2, 2, 2);