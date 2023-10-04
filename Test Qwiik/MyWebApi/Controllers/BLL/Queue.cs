using System;
using System.Collections.Generic;
using System.Linq;


// Business Logic Layer
public class QueueService<T>
{
    private Queue<T> queue = new Queue<T>();

    public void Enqueue(T item)
    {
        queue.Enqueue(item);
    }

    public T Dequeue()
    {
        if (queue.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty.");
        }
        return queue.Dequeue();
    }

    public IEnumerable<T> GetAll()
    {
        return queue.ToList();
    }
}

// Web Layer (Console Application)
/*public class Program
{
    private static IServiceProvider serviceProvider;

    public static void Main()
    {
        // Setup DI container
        ConfigureServices();

        // Use QueueService
        var queueService = serviceProvider.GetRequiredService<QueueService<string>>();

        Console.WriteLine("Adding items to the queue:");
        queueService.Enqueue("Item 1");
        queueService.Enqueue("Item 2");
        queueService.Enqueue("Item 3");

        Console.WriteLine("Dequeuing items from the queue:");
        Console.WriteLine(queueService.Dequeue());
        Console.WriteLine(queueService.Dequeue());
        Console.WriteLine(queueService.Dequeue());

        Console.WriteLine("All items in the queue:");
        var items = queueService.GetAll();
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }

    private static void ConfigureServices()
    {
        var services = new ServiceCollection();
        services.AddSingleton(typeof(QueueService<>));

        serviceProvider = services.BuildServiceProvider();
    }
}*/
