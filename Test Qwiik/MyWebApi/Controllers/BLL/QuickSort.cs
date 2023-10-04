using System;
using System.Linq;

// Business Logic Layer
public class QuickSortService
{
    public void QuickSort(int[] arr)
    {
        QuickSort(arr, 0, arr.Length - 1);
    }

    private void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(arr, low, high);
            QuickSort(arr, low, pivotIndex - 1);
            QuickSort(arr, pivotIndex + 1, high);
        }
    }

    private int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                Swap(arr, i, j);
            }
        }

        Swap(arr, i + 1, high);
        return i + 1;
    }

    private void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}

// Web Layer (Console Application)
/*public class Program
{
    public static void Main()
    {
        // Sample input array
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

        Console.WriteLine("Original Array:");
        Console.WriteLine(string.Join(", ", arr));

        var quickSortService = new QuickSortService();
        quickSortService.QuickSort(arr);

        Console.WriteLine("Sorted Array (QuickSort):");
        Console.WriteLine(string.Join(", ", arr));
    }
}*/
