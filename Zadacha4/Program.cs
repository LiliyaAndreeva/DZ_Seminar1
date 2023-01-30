// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Clear();
Console.Write ("Введите число a: ");
int NumberA = int.Parse(Console.ReadLine());
Console.Write ("Введите число b: ");
int NumberB = int.Parse(Console.ReadLine());
Console.Write ("Введите число c: ");
int NumberC = int.Parse(Console.ReadLine());
int max = NumberA;
if (NumberB > max) max = NumberB;
if (NumberC > max) max = NumberC;  
Console.WriteLine ($"max = {max} ");