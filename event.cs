using System;

// Delegate declaration
delegate void Notify();

class Student
{
    // Event declaration
    public event Notify?StudentRegistered;

    public void Register()
    {
        Console.WriteLine("Student Registration Completed");

        // Raise the event
        StudentRegistered?.Invoke();
    }
}

class Program
{
    // Method to handle the event
    static void ShowMessage()
    {
        Console.WriteLine("Notification: Student Registered Successfully!");
    }

    static void Main()
    {
        Student student = new Student();

        // Subscribe method to event
        student.StudentRegistered += ShowMessage;

        // Register student
        student.Register();

        Console.ReadLine();
    }
}