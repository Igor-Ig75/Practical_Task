/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/


int [] CreateRandomArray(int size, int minValue, int maxValue)   
{
    int [] newArray = new int[size];
    for(int i =0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

int[] CreateArray(int size)
{
    int [] newArray = new int[size];

    Console.WriteLine("Создание массива:");
    for(int i =0; i < size; i++)
    {
        Console.Write($"Входной {i + 1} элемент: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    return newArray;
}

void PrintArray(int[] col)
{
    int count = col.Length;
    Console.Write("[ ");

    for(int position = 0; position < count; position++)
        Console.Write(col[position] + ", ");

    Console.Write("]");
    Console.WriteLine();
}

// Решение задача 34:

int quantityEvenNumbers(int[] newArray)
{
    int count = 0;
    
    for(int i = 0; i < newArray.Length; i++)
    {
        if(newArray[i] % 2 == 0) count++;
    }
    return count;
}


// Решение задачи 36

int sumElementsOddPositions(int[] newArray)
{
    int sum = 0;
    
    for(int i = 1; i < newArray.Length; i=i+2)
    {
        if(newArray[i] % 2 == 1)
        sum = sum + newArray[i];
    }
    return  sum;
}


// Решение задача 38:
int differenceBetweenMaxAndMinElements(int[] newArray)
{
    int difference = 0;
    int max = 0;
    int min = 0;

    for(int i = 1; i < newArray.Length; i++)
    {
        if(newArray[i] > newArray[max]) max = i;
        if(newArray[i] < newArray[min]) min = i;
    }
    difference = newArray[max] - newArray[min];
    return  difference ;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимально возможное значения элементов ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимально возможное значение элементов ");
int max = Convert.ToInt32(Console.ReadLine());

int [] array = CreateRandomArray(size, min, max);    
PrintArray(array);                             
//Console.WriteLine("количество чётных чисел в массиве = " + quantityEvenNumbers(array));                  // Решение задача 34
//Console.WriteLine("сумму элементов, стоящих на нечётных позициях = " + sumElementsOddPositions(array));  // Решение задачи 36
Console.WriteLine("разницу между максимальным и минимальным элементов массива = " 
+ differenceBetweenMaxAndMinElements(array));                                                              // Решение задача 38:
  
// Я наверное с именами перемудрил?