//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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

void odd_nums_sum(int [] arr)
{
    int sum = 0;
    foreach(int n in arr) 
    {
        if (n%2 == 1)
        {
            sum = sum + n;
        }  
         
    }
    Console.WriteLine($"Сумма нечетных чисел: {sum}");       
}

 int [] ms = give_me_array(99, 1000, 7);
 sh_array_num(ms);
 odd_nums_sum(ms);

