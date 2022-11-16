// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


int ResultNumbers(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (n == 0)
        return ResultNumbers (m - 1, 1);
    else
        return ResultNumbers(m - 1, ResultNumbers(m, n - 1)); ;
}


Console.Clear();
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("A(m,n):" + ResultNumbers(n, m));      