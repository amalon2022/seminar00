// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int Num1 = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(Num1);

if (anyNumberText.Length > 2)
{
  Console.WriteLine("третья цифра -> " + anyNumberText[2]);
}
else
{
  Console.WriteLine("третьей цифры нет");
}
