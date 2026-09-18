using System;
using System.Threading;

class Program
{
    static void Task1()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Task 1: " + i);
            Thread.Sleep(500);
        }
    }

    static void Task2()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Task 2: " + i);
            Thread.Sleep(500);
        }
    }

    static void Main()
    {
        // Creating threads
        Thread t1 = new Thread(Task1);
        Thread t2 = new Thread(Task2);

        // Starting threads
        t1.Start();
        t2.Start();

        // Wait for threads to complete
        t1.Join();
        t2.Join();

        Console.WriteLine("Both tasks completed.");

        Console.ReadLine();
    }
}
