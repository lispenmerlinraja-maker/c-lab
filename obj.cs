using System;

class Student
{
    // Fields
    public string name="";
    public int age;

    // Method
    public void Display()
    {
        Console.WriteLine("Student Name: " + name);
        Console.WriteLine("Student Age: " + age);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating object
        Student s1 = new Student();

        // Assigning values
        s1.name = "Antony";
        s1.age = 20;

        // Calling method
        s1.Display();

        Console.ReadLine();
    }
}