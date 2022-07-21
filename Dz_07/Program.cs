/*Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5   7   -2   -0,2
1   -3,3   8   -9,9
8    7,8  -7,1  9
*/
void RandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "; ");
        Console.WriteLine();
    }
}

/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/ 

int[,] CreatRondom2dArray(int rows, int columns, int minValue, int maxValue)   
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(minValue, maxValue +1);
    
    return newArray;
}

void Print2dArray(int[,] array)

{
    for(int i = 0; i < array.GetLength(0); i++)
       { 
            for(int j = 0; j < array.GetLength(1); j++)
                Console.Write(array[i,j] + " ");

            Console.WriteLine();
        }
}

void GetElement(int[,] array, int i, int j) {
    if (i >= array.GetLength(0) || j >= array.GetLength(1)) {
        Console.WriteLine("Элемента не существует");
    }
    else {
        Console.WriteLine("Элемент массива на позиции " + i + ", " + j + " = " + array[i, j]);
    }
}
/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

void GetElement1(int[,] array, int i, int j) {
    if (i >= array.GetLength(0) || j >= array.GetLength(1)) {
        Console.WriteLine("Элемента не существует");
    }
    else {
        Console.WriteLine("Элемент массива на позиции " + i + "," + j + " = " + array[i, j]);
    }
}
//=====================Задача 47====================================================================================

Console.Write("введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] num = new double[m, n];
RandomNumbers(num);
PrintArray(num);

//======================Задача 50===================================================================================

// Console.Write("Ведите количство строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ведите количство столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ведите минимальное значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ведите максимальное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreatRondom2dArray(m,n,min,max);
// Print2dArray(myArray);
// Console.WriteLine();

// Console.Write("Введите позицию i: ");
// int i = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите позицию j: ");
// int j = Convert.ToInt32(Console.ReadLine());
// //иии
// GetElement1(myArray, i, j);

//======================Задача 52===================================================================================

// Console.Write("Ведите количство строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ведите количство столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ведите минимальное значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ведите максимальное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreatRondom2dArray(m,n,min,max);
// Print2dArray(myArray);
// Console.WriteLine();
// for (int j = 0; j < myArray.GetLength(1); j++)
// {
//     double avarage = 0;
//     for (int i = 0; i < myArray.GetLength(0); i++)
//         avarage = (avarage + myArray[i, j]);
//     avarage = avarage / myArray.GetLength(0);
//     Console.WriteLine("Номер столбца " + j + " Среднее арифмитическое = " + avarage);
// }

//=========================================================================================================