﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// Задача не решена. Возиться с графиками функций, потом выводить из них координаты точек, а из них уже как-то выковыривать координаты точки пересечения прямых
// - задача конечно интересная (вспомить школу), но мозги мне выели на работе, так что увы, ливаю.  Намного сложнее всего того, что давалось на домашку раньше

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

int k1 = check_num("Введите k1: ");
int b1 = check_num("Введите b1: ");
int k2 = check_num("Введите k2: ");
int b2 = check_num("Введите b2: ");