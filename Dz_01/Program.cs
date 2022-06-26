/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */
/*
int number1;
int number2;

Console.Write("Введите число: ");
number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
number2 = Convert.ToInt32(Console.ReadLine());

int max = number1, min = number2;

if (number2 > max) max = number2;
if (number1 < max) min = number1;

Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);

*/
/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22  */

/*
int num1;
int num2;
int num3;

Console.Write("Введите число: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if ( num2 > max ) max = num2;
if (num3 > max ) max = num3;

Console.Write("max = ");
Console.WriteLine(max);
*/

/* Задача 6: Напишите программу, 
которая на вход принимает число и выдаёт, 
является ли число чётным 
(делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет  */

int num;

Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.Write("Это число четное = ");
    Console.WriteLine(num);
}
else
{
    Console.Write("Это число не четное = ");
    Console.WriteLine(num);
}

/*Задача 8: Напишите программу, 
которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/
/*
int n, current;

Console.Write("Введите число: "); 
n = Convert.ToInt32(Console.ReadLine());

current = 2;

while(current <= n)
{
    Console.Write(current + " ");
    current = current + 2;
}
*/