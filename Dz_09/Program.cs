/*Задача 64: Задайте значение N. Напишите программу, 
которая найдет кол-во цифр в числе N рекурсивным методом.       1 2 3 4 = 4
N = 4532 -> 4*/

int QuantityDigits (int n)
{
    if (n/10!=0) return 1+QuantityDigits(n/10);
    else return 1;
}

Console.Write("Ведите число: ");
int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(QuantityDigits(4234));
Console.WriteLine($"Количество  цифр в числе {n} = {QuantityDigits(n)}");   
Console.WriteLine(); 

//============================================================================================
/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
int SumOfElementsInterval (int m, int n)
{
    if(m < n) return m + SumOfElementsInterval(m + 1, n);
    return m;
}
//Console.WriteLine(SumOfElementsInterval(4, 8));
Console.Write("Ведите число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумму натуральных элементов в промежутке от {M} до {N} = {SumOfElementsInterval(M, N)}");  
