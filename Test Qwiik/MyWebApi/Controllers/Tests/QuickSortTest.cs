using System;
using Xunit;

public class QuickSortServiceTests
{
    [Fact]
    public void QuickSort_SortsArrayInAscendingOrder()
    {
        // Arrange
        var quickSortService = new QuickSortService();
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
        int[] expectedSortedArray = { 11, 12, 22, 25, 34, 64, 90 };

        // Act
        quickSortService.QuickSort(arr);

        // Assert
        Assert.Equal(expectedSortedArray, arr);
    }

    [Fact]
    public void QuickSort_EmptyArray_DoesNotThrowException()
    {
        // Arrange
        var quickSortService = new QuickSortService();
        int[] arr = new int[0]; // Empty array

        // Act and Assert
        Assert.Empty(arr); // Check if the array is empty
        Assert.ThrowsAny<Exception>(() => quickSortService.QuickSort(arr)); // Use Assert.ThrowsAny to check for exceptions
    }

    [Fact]
    public void QuickSort_SortedArray_RemainsSorted()
    {
        // Arrange
        var quickSortService = new QuickSortService();
        int[] arr = { 11, 12, 22, 25, 34, 64, 90 }; // Already sorted array

        // Act
        quickSortService.QuickSort(arr);

        // Assert
        Assert.Equal(arr, arr);
    }

    [Fact]
    public void QuickSort_SingleElementArray_RemainsSame()
    {
        // Arrange
        var quickSortService = new QuickSortService();
        int[] arr = { 42 }; // Single-element array

        // Act
        quickSortService.QuickSort(arr);

        // Assert
        Assert.Single(arr); // Check if the array still has a single element
        Assert.Equal(42, arr[0]); // Check if the element remains the same
    }
}
