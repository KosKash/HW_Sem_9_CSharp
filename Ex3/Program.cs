/*Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29*/
Console.Clear();
Console.Write("Введите число M "); int mNum = int.Parse(Console.ReadLine());
Console.Write("Введите число N "); int nNum = int.Parse(Console.ReadLine());
int Acermann(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0)
        return Acermann(m - 1, 1);
    else
        return Acermann(m - 1, Acermann(m, n - 1));
}
int res = Acermann(mNum, nNum);
System.Console.WriteLine(res);
