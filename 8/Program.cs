// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num <= 0)
{
    Console.WriteLine($"Сказали же, что от 1го до N !!");
}
for (int i = 2; i <= num; i = i + 2)
{
    Console.WriteLine(i);
}
