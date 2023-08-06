 /*Задайте одномерный массив, заполненный 
 случайными числами. Найдите сумму элементов, 
 стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

using System;

class Program
{
    static void Main(string[] args)
    {
       
        int[] arr = new int[4];
        Random rnd = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(-10, 10);
        }

        Console.WriteLine("Массив:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

    
        int sum = SumOddPositions(arr);
        Console.WriteLine("Сумма элементов, стоящих на нечетных позициях: " + sum);

        Console.ReadLine();
    }

    static int SumOddPositions(int[] arr)
    {
        int sum = 0;
        for (int i = 1; i < arr.Length; i += 2)
        {
            sum += arr[i];
        }
        return sum;
    }
}

