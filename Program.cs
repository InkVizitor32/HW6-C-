// Задача 41: Пользователь вводит с клавиатуры M чисел.
//            Посчитайте, сколько чисел больше 0 ввёл пользователь.

//             0, 7, 8, -2, -2 -> 2
//             1, -7, 567, 89, 223-> 3
Console.Clear();
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

int[] CreateFillArray()
{

    int[] arr = new int[N];
    for (int i = 0; i < N; i++)
    {
        Console.Write($"введите {(i + 1)}-е число ");
        int a = Convert.ToInt32(Console.ReadLine());
        arr[i] = a;
    }
    return arr;
}

void PrintArray(int[] array)
{

    for (int i = 0; i < N; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}



void FindCount(int[] array)
{
    int count = 0;
    foreach (int el in array)
    {
        if (el > 0) count++;
    } 
    Console.WriteLine($"количество положительных чисел равно {count}");
}
int[] mass = CreateFillArray();
Console.WriteLine();
PrintArray(mass);
Console.WriteLine();
FindCount(mass);
Console.WriteLine();
