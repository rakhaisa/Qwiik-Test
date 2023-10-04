using System;
using System.Collections.Generic;
using System.Linq;

public class FibonacciGenerator
{
    public List<int> GenerateFibonacciSeries(int limit)
    {
        if (limit < 1)
        {
            throw new ArgumentException("Limit must be greater than or equal to 1.");
        }

        List<int> series = new List<int> { 0, 1 };
        while (series.Last() + series[series.Count - 2] <= limit)
        {
            series.Add(series.Last() + series[series.Count - 2]);
        }

        return series;
    }
}

/*public partial class Program
{
    public static void Main()
    {
        int limit;
        
        Console.Write("Enter the limit for the Fibonacci series: ");
        limit = Convert.ToInt32(Console.ReadLine());

        var fibonacciGenerator = new FibonacciGenerator();
        List<int> series = fibonacciGenerator.GenerateFibonacciSeries(limit);

        Console.WriteLine("Fibonacci series:");
        foreach (int num in series)
        {
            Console.Write(num + " ");
        }
    }
}*/
