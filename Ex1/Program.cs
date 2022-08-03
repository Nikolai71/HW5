// Задача 29: 
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (вводим массив с клавиатуры (т. е. через консоль :) ))

int N = 8;

int[] myArray = new int[N];

for (int i=0; i<N; i++)

myArray[i] = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < N; i++)

Console.Write("{0} ", myArray[i]);




// Задача 29 A (Так мне кажется интереснее): 
// Напишите программу, которая задаёт массив из N элементов и выводит их на экран. (вводим массив с клавиатуры (т. е. через консоль :) ))


// Console.Write("Введите желаемый размер массива ");

// /*N - размер массива.*/
// int N = Convert.ToInt32(Console.ReadLine());
//
// /*Создал массив.*/
// int[] myArray = new int[N];
//
// /*Ввод с клавиатуры.*/
// for (int i=0; i<N; i++)
// 
// myArray[i] = Convert.ToInt32(Console.ReadLine());
//
// /*Вывод на экран.*/
// for (int i = 0; i < N; i++)
// Console.Write("{0} ", myArray[i]);
