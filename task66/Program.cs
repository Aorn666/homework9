// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int ResultNumbers(int a, int b)
{
if (b == a)
return a;
return ResultNumbers(a, b -1 ) + b;
}


Console.Clear();
Console.Write("Введите 1-ое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ResultNumbers(a, b));