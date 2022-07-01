/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int CutNumber()  
{
    int num = new Random().Next(100,1000);   
    Console.WriteLine("Current random number is " + num);  

    int ten = num % 100;  
    int ed = ten / 10;

    int result = ed;
    return result;          
}

int number = CutNumber();   
Console.WriteLine("Result number is " + number);  


/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/
/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
void DayWeek (int number)
{
   if(number == 1) Console.WriteLine(number + " -> Да");

   if(number == 2) Console.WriteLine(number + " -> Да");

   if(number == 3) Console.WriteLine(number + " -> Да");

   if(number == 4) Console.WriteLine(number + " -> Да");

   if(number == 5) Console.WriteLine(number + " -> Да");

   if(number == 6) Console.WriteLine(number + " -> Да");

   if(number == 7) Console.WriteLine(number + " -> Да");

   if(number > 7 || number < 1) Console.WriteLine(number + " -> Нет");

}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
DayWeek(num);