//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());


if (num1 > num2)
{
    Console.WriteLine($"Число {num1} максимальое");
}
else if (num2 > num1)
{
    Console.WriteLine($"Число {num2} максимальое");
}
else
{
    Console.WriteLine("Не нужно вводить равные числа");
}