/*Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8 -> 30*/
Console.Clear();
Console.Write("Введите число M ");
int mNum = int.Parse(Console.ReadLine());
Console.Write("Введите число N ");
int nNum = int.Parse(Console.ReadLine());
int sum = 0;
void Sum(int firstNum, int secondNum)
{
    sum += firstNum;
    firstNum++;
    if (firstNum <= secondNum) Sum(firstNum, secondNum);
    else System.Console.WriteLine($"Сумма чисел = {sum}");
}
Sum(mNum, nNum);