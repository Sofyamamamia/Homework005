/*Задайте массив заполненный 
случайными положительными трёхзначными 
числами. Напишите программу, которая 
покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

using System;

class Program
{
    static void Main()
    {
        // Создаем массив и заполняем его случайными трехзначными числами
        int[] arr = new int[4];
        Random rnd = new  ();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(100, 1000);
        }

        // Выводим массив на экран
        Console.WriteLine("Массив:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // Вызываем функцию и выводим результат на экран
        int evenCount = CountEven(arr);
        Console.WriteLine("Количество четных чисел: " + evenCount);

        Console.ReadLine();
    }

    // Функция для подсчета количества четных чисел в массиве
    static int CountEven(int[] arr)
    {
        int count = 0;
        foreach (int num in arr)
        {
            if (num % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }
}
