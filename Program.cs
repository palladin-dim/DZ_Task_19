/* Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Палиндром — это строка(или число), которое можно прочитать одинаково справа налево, либо слева направо
14212 -> нет
12821 -> да
23432 -> да */

Console.Write("Введите пятизначное число: ");
string? number = Console.ReadLine();
// ? Знак "?" с права от типа допускает значение null
void CheckingNumber(string number){
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"Ваше число: {number} -> да, палиндром");
  }
  else Console.WriteLine($"Ваше число: {number} -> нет, не палиндром.");
  }
  
  if (number!.Length == 5){
    CheckingNumber(number);
  }
  else Console.WriteLine($"Число не пятизначное ");