// Задача 34: Задайте массив 
// заполненный случайными положительными 
// трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел 
// в массиве.
// [345, 897, 568, 234] -> 2

// int[] array = new int[4];
// Console.Write("[");
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(100, 1000);
//     Console.Write(array[i] + ",");
// }
// Console.Write("]");
// int count = 0;
// for (int i = 0; i < array.Length; i++)
//     if (array[i] % 2 == 0)
//     {
//         count++;
//     }
// Console.Write("Четные чисел в массиве = " + count);


// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] array = new int[4];
// Console.Write("[");
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(1, 100);
//     Console.Write(array[i] + " ");
// }
// Console.Write("]");
// int sum = 0;
// for (int i = 0; i < array.Length; i += 2)
//     sum = sum + array[i];
// Console.Write($"Сумма элементов, стоящих на нечетных позициях = {sum}");


// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// Console.WriteLine("Введите количество элеметнов массива");
// int num = Convert.ToInt32(Console.ReadLine());
// double[] random_array = new double[num];
// Console.Write("Массив: ");
// void Array(int num)
// {
//     for (int i = 0; i < num; i++)
//     {
//         random_array[i] = Math.Round(new Random().NextDouble(), 2);
//         Console.WriteLine(random_array[i]);
//     }
// }
// double Diff(double[] random_array)
// {
//     double min = random_array[0];
//     double max = random_array[0];
//     int i = 1;
//     while (i < random_array.Length)
//     {
//         if (random_array[i] > max)
//             max = random_array[i];
//         if (random_array[i] < min)
//             min = random_array[i];
//         i = i + 1;
//     }
//     return max - min;
// }
// Array(num);
// Console.Write($"Разница между максимальным и минимальным элементами массива = {Diff(random_array)}");

// Задачу 38 подсмотрел в записи к семинару, сам не осилил.
