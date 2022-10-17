// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите первое число ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int numberN = Convert.ToInt32(Console.ReadLine());
int sum = 0;
sum += NaturalSumFromMToN(numberM, numberN);
Console.Write($"Сумма = {sum} ");

int NaturalSumFromMToN(int numM, int numN)
{
    if (numN == numM) return numM;
    if (numM < numN)
    {

        return numM + NaturalSumFromMToN(numM + 1, numN);
    }
    if (numM > numN)
    {
        return numM + NaturalSumFromMToN(numM - 1, numN);
    }
    return 0;
}
