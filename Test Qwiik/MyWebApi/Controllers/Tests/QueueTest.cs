using System;
using System.Collections.Generic;
using Xunit;
using Moq;

public class QueueServiceTests
{
    [Fact]
    public void Enqueue_AddsItemToQueue()
    {
        // Arrange
        var queueService = new QueueService<string>();
        string itemToAdd = "TestItem";

        // Act
        queueService.Enqueue(itemToAdd);

        // Assert
        var items = queueService.GetAll();
        Assert.Contains(itemToAdd, items);
    }

    [Fact]
    public void Dequeue_RemovesAndReturnsItemFromQueue()
    {
        // Arrange
        var queueService = new QueueService<string>();
        string item1 = "Item1";
        string item2 = "Item2";
        queueService.Enqueue(item1);
        queueService.Enqueue(item2);

        // Act
        string dequeuedItem = queueService.Dequeue();

        // Assert
        var items = queueService.GetAll();
        Assert.DoesNotContain(dequeuedItem, items);
        Assert.Equal(item1, dequeuedItem);
    }

    [Fact]
    public void Dequeue_ThrowsExceptionWhenQueueIsEmpty()
    {
        // Arrange
        var queueService = new QueueService<string>();

        // Act and Assert
        Assert.Throws<InvalidOperationException>(() => queueService.Dequeue());
    }
}
