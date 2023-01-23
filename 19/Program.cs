// 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Задачу я усложню и напишу проверку вне завимисимости, пятизначное число или нет.

Console.Write("Введите целое число для палиндрома: ");

string num = Console.ReadLine();
string[] mirror_array = new string[num.Length];
// Console.WriteLine(mirror_array); // Вывод массива через стринг джоин (Вот так вот cw(mirror_array) выведет только тип массива)
int mirror_array_index = 0;

for (int i = num.Length - 1; i >= 0; i--)
{
    mirror_array[mirror_array_index] = Convert.ToString(num[i]); // 
    mirror_array_index++;
}
//Console.WriteLine(string.Join("", mirror_array)); // Вывод массива через стринг джоин (Вот так вот cw(mirror_array) выведет только тип массива)

string str_mirror_array = string.Join("", mirror_array);

if (num == str_mirror_array)
   Console.WriteLine("Палиндром");
else
    Console.WriteLine("Не получилось, не фортануло (с)");




