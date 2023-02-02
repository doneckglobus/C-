//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

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

void middle_sum(int [] arr)
{
    int min = arr[0];
    int max = arr[0];
    foreach(int n in arr) 
    {
        if (n < min)
            min = n;
        if (n > max)
            max = n;     
    }
    Console.WriteLine($"{min}  {max}");      
    int msum = max - min;
    Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {msum}");       
}

 int [] ms = give_me_array(1, 9, 4);
 sh_array_num(ms);
 middle_sum(ms);
