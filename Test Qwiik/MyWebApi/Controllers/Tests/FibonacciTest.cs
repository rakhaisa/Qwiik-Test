using System;
using System.Collections.Generic;
using Xunit;
using Moq;

public class FibonacciGeneratorTests
{
    private readonly FibonacciGenerator generator;

    public FibonacciGeneratorTests()
    {
        generator = new FibonacciGenerator();
    }

    [Fact]
    public void GenerateFibonacciSeries_WithValidLimit_ReturnsCorrectSeries()
    {
        // Arrange
        int limit = 10; // Limiting the Fibonacci series to 10

        // Act
        var series = generator.GenerateFibonacciSeries(limit);

        // Assert
        int[] expectedSeries = { 0, 1, 1, 2, 3, 5, 8 };
        Assert.Equal(expectedSeries, series);
    }

    [Fact]
    public void GenerateFibonacciSeries_WithLimitOf1_ReturnsSingleElement()
    {
        // Arrange
        int limit = 1; // Limiting the Fibonacci series to 1

        // Act
        var series = generator.GenerateFibonacciSeries(limit);

        // Assert
        int[] expectedSeries = { 0, 1 };
        Assert.Equal(expectedSeries, series);
    }

    [Fact]
    public void GenerateFibonacciSeries_WithLimitOfNegativeValue_ThrowsArgumentException()
    {
        // Arrange
        int limit = -5; // Negative limit

        // Act and Assert
        Assert.Throws<ArgumentException>(() => generator.GenerateFibonacciSeries(limit));
    }
}

internal class FactAttribute : Attribute
{
}