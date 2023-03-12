
// Написать программу, которая из имеющегося массива строк формирует массив строк, длина которых меньше либо равна трем символам
// Первоначальный массив можно ввести с клавиатуры, либо задать на старты выполнения алгоритма.

int[] create_new_array(int [] array) 
{
    int n = 0; // счетчик значений массива с элементами длина которых меньше или равна трем
    foreach(int i in array)
    {
        string str_i = $"{i}";
        if (str_i.Length <= 3)
            {
                n++;
            }
    }
    // Мы получили количество элеметов с длиной элементов меньше трех, теперь нужно создать новый массив и заполнить его этими элементами
    int[] nums = new int[n]; // создание массива для элементов длина которых меньше или равна трем
    int x = 0; // счеткик элементов массива nums
    foreach(int y in array)
    {
        string str_y = $"{y}";
        if (str_y.Length <= 3)
            {
                nums[x] = y;
                x++;
            }
    }
    return nums;
}


 void sh_array_num(int [] array)
 {
    Console.WriteLine($"Полученный массив: ");
    foreach(var c in array) 
        { 
            Console.Write($"{c} "); 
        }
    Console.WriteLine("");
 }



int[] nums = new int[] { 1, 22, 3333, 4444, 55555, 33 };
sh_array_num(create_new_array(nums));