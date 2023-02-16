// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int sum(int m, int n)
{
if (m==n)
    return 0;
else
    return m + sum(m+1, n);
}
System.Console.WriteLine(sum(2, 5));

