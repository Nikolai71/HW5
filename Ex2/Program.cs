// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число ");

int N = Convert.ToInt32(Console.ReadLine());

int number1 = N / 1000;
Console.WriteLine($"цифра 1 = {number1}");
int number21 = N / 100 % 100;
int number2 = number21 % 10;
Console.WriteLine($"цифра 2 = {number2}");
int number3 = N / 10 % 10;
Console.WriteLine($"цифра 3 = {number3}");
int number4 = N % 10;
Console.WriteLine($"цифра 4 = {number4}");
int sum = (number1 + number2 + number3 + number4);

Console.WriteLine($"Сумма чисел = {sum}");

// Напишите программу, которая выводит случайное число из отрезка [10, 999] и показывает наибольшую цифру числа.
// 78 -> 8; 12 -> 2; 85 -> 8.
// int number = new Random ().Next(10, 1000);
// Console.WriteLine($"Случайное число = {number}");
// Console.WriteLine();
// int digit1 = number / 100; // 480 / 100 = 48
// int max = digit1;
// Console.WriteLine($"цифра 1 = {digit1}");
// int digit2 = number / 10 % 10; // 480/10 % 10 = 80
// Console.WriteLine($"цифра 2 = {digit2}");
// int digit3 = number % 10; // 480 % 10 =0
// Console.WriteLine($"цифра 3 = {digit3}");
// Console.WriteLine();
//
// if (digit2 > max) max = digit2;
//
// if (digit3 > max) max =digit3;
//
// Console.WriteLine($"Максимальное значение = {max}");
