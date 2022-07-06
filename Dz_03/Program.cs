/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
/*
string Kolich(string num)
{
   if(num[0] == num[4] && num[1] == num[3])
      Console.WriteLine($"Ваше число: {num} - палиндром.");
      
   else
      Console.WriteLine($"Ваше число: {num} - НЕ палиндром.");
   return num;
}

Console.Write("Введите число ");
int num1 = Convert.ToInt32(Console.ReadLine());

//int num1 = new Random().Next(9999,100000);
//Console.WriteLine(num1);

string numbers = Kolich(num1.ToString());
 */
/*
Задача 23
Напишите программу, которая принимает 
на вход число (N) и выдаёт таблицу 
кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int[] Table(int N)
{
    int[] NumArray = new int[N];
    int number = 1;
    for (int i = 0; i < N; i++)
    {
        NumArray[i] = number * 3;
        number++;
    }
    return NumArray;
}

void PrintTable(int[] array)
{
    int number = 1;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{number} ^ 3 = ");
        Console.WriteLine(array[i]);
        number++;
    }
}

Console.Write($"Введите число: ");
string num = Console.ReadLine();
int N = Convert.ToInt32(num);
int[] YmnTable = Table(N);
PrintTable(YmnTable);