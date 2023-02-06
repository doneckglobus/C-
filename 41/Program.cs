
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


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

int number_of_digits(int a, int b) // где a и b - диапазон чисел
{
    Random rand = new Random();
    int num = rand.Next(a, b);
    Console.Write($" Число цифр для ввода (М): {num}");
    Console.WriteLine("");
    return num;
}


int[] greater_than_zero(int num)
{
    int[] array = new int[num];
    for(int i = 0; i < num; i++)
    {
        int entered_num = check_num("Введите число: ");
        array[i] = entered_num; 
    }
    return array;
}

 void sh_array_num(int [] array)
 {
    Console.WriteLine($"Полученный массив: ");
    Console.Write($"[");
    foreach(var c in array) 
        {
            if (c > 0) 
                Console.Write($"{c} "); 
        }
    Console.Write($"]");  
    Console.WriteLine("");
 }


sh_array_num(greater_than_zero(number_of_digits(0, 7)));
