// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] give_me_array(int a, int b, int c) // где a и b - диапазон чисел, c - их количество 
{
    int[] array = new int[c];
    Random rand = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(a, b);
    }
    return array;
}

 void sh_array_num(int [] array)
 {
    Console.WriteLine($"Полученный массив: ");
    foreach(var c in array) 
        { 
            Console.Write($"{c} "); 
        }
    Console.WriteLine("");
 }

void even_nums_show(int [] arr)
{
    Console.WriteLine("Из него четные числа: ");
    foreach(int n in arr) 
    {
        if (n%2 == 0)
        {
            Console.Write($"{n} ");
        }       
    }
   
}

 int [] ms = give_me_array(99, 1000, 7);
 sh_array_num(ms);
 even_nums_show(ms);
