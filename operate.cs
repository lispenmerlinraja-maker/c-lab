using System;

class Number
{
    public int value;

    // Constructor
    public Number(int value)
    {
        this.value = value;
    }

    // Operator overloading
    public static Number operator +(Number n1, Number n2)
    {
        return new Number(n1.value + n2.value);
    }
}

class Program
{
    static void Main()
    {
        Number n1 = new Number(10);
        Number n2 = new Number(20);

        Number n3 = n1 + n2;

        Console.WriteLine("Sum = " + n3.value);

        Console.ReadLine();
    }
}