// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

// Условия и ввод

Console.Clear();

Console.Write("Ввести первое число: ");
int first = int.Parse(Console.ReadLine());
Console.Write("Ввести второе число: ");
int second = int.Parse(Console.ReadLine());
Console.Write("Ввести третье число: ");
int third = int.Parse(Console.ReadLine());

int max = first;

// Сравнение и вывод
if (second > max)
Console.WriteLine("max: " + second);
else if
(third > max)
Console.WriteLine("max: " + third);