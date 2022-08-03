// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//
// 3, 5 -> 243 (3⁵)
//
// 2, 4 -> 16
//
// Использование Math.Pow() и аналогов = Ban :)

Console.Write("Введите Число a ");
int a = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите Число b ");
int b = Convert.ToInt32(Console.ReadLine());


double pow_ab = Math.Pow(a, b);
  
Console.WriteLine(pow_ab);


// 12. Напишите программу, которая на вход принимает число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет; 46 -> неи; 161 -> да
// Console.WriteLine("Введите число ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// int mod1 = number1 % 7;
// if (mod1 == 0)
// Console.WriteLine("Да");
// else
// Console.WriteLine($"нет, остаток = {mod1}");
// int mod2 = number1 % 23;
// if (mod2 == 0)
// Console.WriteLine("Да");
// else
// Console.WriteLine($"нет, остаток = {mod2}");