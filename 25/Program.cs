// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

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

double sqr_all_plus(int num, int num2)
{
    double result = num;
    for (int i = 1; i < num2; i++)
        result = result * num;
    return result;
    
}   
 


while(true) 
{
    int num = check_num("Введите число возводимое в степень: ");
    int num2 = check_num("Введите степень числа: ");
    double rst = sqr_all_plus(num, num2);
    Console.WriteLine($"Результат {rst}");
}