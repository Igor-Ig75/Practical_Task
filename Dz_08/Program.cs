
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

/*Задача 54: ============================================================================
Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8*/

void SelectionSort(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int c = 1;  c < array.GetLength(1); c++)           // блок код ищит только минимальный элемент
            {
                if(array[i, c] < array[i, c-1]) 
                {
                    int temp = array[i, c - 1];
                    array[i, c - 1] = array[i, c];
                    array[i, c] = temp;  
                }     
            }
        }
}

Console.Write("Ведите количство строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите количство столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreatRondom2dArray(m,n,min,max);
Print2dArray(myArray);
Console.WriteLine();
SelectionSort(myArray);
Print2dArray(myArray);

/*Задача 56: ============================================================================
Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7 
Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int minSum = int.MaxValue, indexMin = 0;
 
for (int i = 0; i < myArray.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < myArray.GetLength(1); j++)
        sum = (sum + myArray[i, j]);
        Console.WriteLine("Номер строки " + i + " сумма = " + sum);
    if (sum < minSum)
    {
        minSum = sum;
        indexMin = i;
    }
}
Console.Write("Строка № " + indexMin + " с минимальной суммой элементов ");
for(int j = 0; j < myArray.GetLength(1); j++)
Console.Write(myArray[indexMin, j]);               
Console.WriteLine();                

/* Задача 62. ============================================================================
Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7 */ 

int[,] matrix = new int[4, 4];          
Print2dArray(matrix);                     
Console.WriteLine();
matrix[0,0] = 1;
matrix[0,1] = 2;
matrix[0,2] = 3;
matrix[0,3] = 4;

matrix[1,0] = 12;
matrix[1,1] = 13;
matrix[1,2] = 14;
matrix[1,3] = 5;

matrix[2,0] = 11;
matrix[2,1] = 16;
matrix[2,2] = 15;
matrix[2,3] = 6;

matrix[3,0] = 10;
matrix[3,1] = 9;
matrix[3,2] = 8;
matrix[3,3] = 7;

Print2dArray(matrix);     