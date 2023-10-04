using System;
using System.Collections.Generic;
using System.Linq;

public partial class Program
{
    public static void Main()
    {
        // Triangle Type Identification
        double side1 = 5, side2 = 5, side3 = 5;
        var triangleIdentifier = new TriangleIdentifier();
        TriangleType type = triangleIdentifier.IdentifyTriangleType(side1, side2, side3);
        Console.WriteLine($"Triangle type: {type}");

        // Fibonacci Series Generation
        int fibonacciLimit = 50;
        var fibonacciGenerator = new FibonacciGenerator();
        List<int> fibonacciSeries = fibonacciGenerator.GenerateFibonacciSeries(fibonacciLimit);
        Console.WriteLine("Fibonacci series:");
        Console.WriteLine(string.Join(", ", fibonacciSeries));

        // Queue Usage
        var queueService = new QueueService<string>();
        queueService.Enqueue("Item 1");
        queueService.Enqueue("Item 2");
        string dequeuedItem = queueService.Dequeue();
        Console.WriteLine($"Dequeued item: {dequeuedItem}");
        Console.WriteLine("All items in the queue:");
        foreach (var item in queueService.GetAll())
        {
            Console.WriteLine(item);
        }

        // Sorting using QuickSort
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

        Console.WriteLine("Original Array:");
        Console.WriteLine(string.Join(", ", arr));

        var quickSortService = new QuickSortService();
        quickSortService.QuickSort(arr);

        Console.WriteLine("Sorted Array (QuickSort):");
        Console.WriteLine(string.Join(", ", arr));
    }
}