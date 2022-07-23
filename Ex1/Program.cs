/* Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"*/
Console.Clear();
Console.Write("Введите число M ");
int mNum = int.Parse(Console.ReadLine());
Console.Write("Введите число N ");
int nNum = int.Parse(Console.ReadLine());
void X2toNum(int firstNum, int secondNum)
{
    if (firstNum % 2 == 0) System.Console.Write($"{firstNum} ");
    firstNum++;
    if (firstNum <= secondNum) X2toNum(firstNum, secondNum);
}
X2toNum(mNum, nNum);
