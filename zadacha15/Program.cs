// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру: ");
int num = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber)
{
  if (num == 6 || num == 7) 
  {
  Console.WriteLine("выходной день");
  }
  else if (num < 1 || num > 7) 
   {
    Console.WriteLine("рабочий день");
   }
  else Console.WriteLine("раб день");
}

 CheckingTheDayOfTheWeek(num);