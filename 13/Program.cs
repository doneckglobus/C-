// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите целое  число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num2 > 99)
{
    while ( num2 > 999)
    {
        num2 = num2 / 10;
    }

    Console.WriteLine(num2 % 10);
}
else
    {
       Console.WriteLine("Цифры Нееееет!! (Luke Skywalker)!"); 
    }
 
// Строкой

Console.Write("Введите целое число: ");
string num = Console.ReadLine();
if (num.Length >= 3) 
{ 
    Console.WriteLine($"Требуемое число: {num[2]}");
}    
else
{
    Console.WriteLine("Третьей цифры нет");
}




