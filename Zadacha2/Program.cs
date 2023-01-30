// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.Write ("Введите число a: ");
int NumberA = int.Parse(Console.ReadLine());
Console.Write ("Введите число b: ");
int NumberB = int.Parse(Console.ReadLine());
if (NumberA > NumberB)
    { 
        Console.WriteLine ($"max={NumberA}");
        return;
    }
    else Console.WriteLine ($"max={NumberB}");