//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье целое число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2 && num1 > num3 )
{
    Console.WriteLine($"Число {num1} максимальое");
}
else if (num2 > num1 && num2 > num3)
{
    Console.WriteLine($"Число {num2} максимальое");
}
else if (num3 > num2 && num3 > num1)
{
    Console.WriteLine($"Число {num3} максимальое");
}
else
{
    Console.WriteLine("Хотя бы одно число долно отличаться от остальных");
}
