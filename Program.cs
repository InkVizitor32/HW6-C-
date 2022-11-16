// // Задача 41: Пользователь вводит с клавиатуры M чисел.
// //            Посчитайте, сколько чисел больше 0 ввёл пользователь.

// //             0, 7, 8, -2, -2 -> 2
// //             1, -7, 567, 89, 223-> 3
// Console.Clear();
// Console.WriteLine("Введите число N");
// int N = Convert.ToInt32(Console.ReadLine());

// int[] CreateFillArray()
// {

//     int[] arr = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         Console.Write($"введите {(i + 1)}-е число ");
//         int a = Convert.ToInt32(Console.ReadLine());
//         arr[i] = a;
//     }
//     return arr;
// }

// void PrintArray(int[] array)
// {

//     for (int i = 0; i < N; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }



// void FindCount(int[] array)
// {
//     int count = 0;
//     foreach (int el in array)
//     {
//         if (el > 0) count++;
//     } 
//     Console.WriteLine($"количество положительных чисел равно {count}");
// }
// int[] mass = CreateFillArray();
// Console.WriteLine();
// PrintArray(mass);
// Console.WriteLine();
// FindCount(mass);
// Console.WriteLine();




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//            заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//            значения b1, k1, b2 и k2 задаются пользователем.

//            b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.Write("введите b1 - ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("введите k1 - ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("введите b2 - ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("введите k2 - ");
double k2 = Convert.ToDouble(Console.ReadLine());

// y = k1 * x + b1, y = k2 * x + b2;

void Metod()
{
    double x = (b2 - b1) / (k1 - k2);
    
    double y = k1 * ((b2 - b1) / (k1 - k2)) + b1;
    x = Math.Round(x, 4);
    y = Math.Round(y, 4);
    if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают");
    else if (k1 == k2) Console.WriteLine("Прямые параллельны");
    else Console.WriteLine($"координаты пересечения прямых ({x}; {y})");
}
Metod();


