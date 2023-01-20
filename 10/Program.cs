// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите целое трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if ( 99 < num && num < 1000)
{ 
    Console.WriteLine($"Требуемое число: {num / 10 % 10}");
}    
else
{
    Console.WriteLine($"Введите трехзначное число");
}

// Теперь решение строками:

Console.Write("Введите целое трехзначное число: ");
string NumStr = Console.ReadLine();
if (NumStr.Length == 3)
{
    Console.WriteLine(NumStr[1]);
}
else
{
    Console.WriteLine("Введите трехзначное число");
}


