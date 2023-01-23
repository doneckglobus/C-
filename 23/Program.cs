// 23.Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
double num = Convert.ToInt32(Console.ReadLine());
 if (num > 0)
    for (int i =  1; i <= num; i++)
    {
        Console.WriteLine(Math.Pow(i, 3));
    }
else if (num < 0)
    for (int i =  -1; i >= num; i--)
    {
        Console.WriteLine(Math.Pow(i, 3));
    }
else
    Console.WriteLine("Ноль в любой степени останется нолём");



