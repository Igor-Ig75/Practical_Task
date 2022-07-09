/*Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int Summa(int num)
{
    int sum = 0;
    while(num > 0)
    {
        int num1 = num % 10;
        num = num / 10;
        sum = sum + num1;
        
    }
    return sum;
}

Console.Write("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумму цифр в числе = {Summa(n)}");


/*Задача 29: Напишите программу, которая задаёт 
массив из m элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/
/*
void FillArray(int[] collection, int rangeStart, int rangeEnd)
{
    int length = collection.Length;

    for(int i = 0; i < length; i++)
        collection[i] = new Random().Next(rangeStart, rangeEnd);
}

void PrintArray(int[] col)
{
    int count = col.Length;
    Console.Write("[ ");
    for(int position = 0; position < count; position++)
        Console.Write(col[position] + ", ");
    Console.Write("]");
}

int[] array = new int[10];

FillArray(array, -10, 10);
PrintArray(array);

*/