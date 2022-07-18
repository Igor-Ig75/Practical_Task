/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3

Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями  y = k1 * x + b1,  y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/


void Numbers(int[] newArray)
{
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write($"Введи {i+1} число: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
}

// Решение задача 41:

int quantityNumbers(int[] newArray)
{
    int count = 0;
    
    for(int i = 0; i < newArray.Length; i++)
        if(newArray[i] > 0) count++;
    
    return count;
}   

// Решение задачи 43:

void Urovnenie(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2); 
    double y = k1 * (b2 - b1) / (k1 - k2) + b1; 
    if(k1 == k2)
        Console.WriteLine("Прямые параллельные");
     else
        Console.WriteLine("Ответ: (" + x +"; "+ y + ")");
}

//================================Решение задача 41===================================================
/*
Console.Clear();
Console.Write($"Введи количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] newArray = new int[m];

Numbers(newArray);              
Console.WriteLine($"Количество  чисел больше 0 = {quantityNumbers(newArray)}");     // Решение задача 41: 
*/

//================================Решение задача 43===================================================

Console.Write("Введите b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());
Urovnenie(b1, k1, b2,  k2);   
Console.WriteLine();   



