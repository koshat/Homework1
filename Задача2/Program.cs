// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


// Условия и ввод

Console.Clear();

Console.Write("Ввести первое число: ");
int first = int.Parse(Console.ReadLine());
Console.Write("Ввести второе число: ");
int second = int.Parse(Console.ReadLine());

// Сравнение и вывод
if (first > second)
Console.WriteLine("max: " + first);
else if
(first < second)
Console.WriteLine("max: " + second);
else if
(first == second)
Console.WriteLine("Числ равны");
