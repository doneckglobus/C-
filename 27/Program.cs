// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

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

string int_to_srt(int num)
{
    string str = $"{num}";
    return str;
}

int DoiT(string str)
{
    int sum = 0;
    foreach(var c in str) 
        { 
            sum = sum + Convert.ToInt32(c.ToString()); 
        }
    return sum;
}


int num = check_num("Введите число: ");
string num2 = int_to_srt(num);
Console.Write($"Сумма его внутренних чисел равна {DoiT(num2)}"); 