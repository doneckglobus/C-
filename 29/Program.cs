// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. А также суммирует их (отсебятина)

int[] give_me_array()
{
    int[] array = new int[8];
    Random rand = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(0,10);
    }
    return array;
}

int[] arr = give_me_array();

Console.Write("Массив '"); 
foreach(var c in arr) 
{ 
    Console.Write(c); 
}
Console.Write($"', сумма его чисел равна {arr.Sum()}"); 


