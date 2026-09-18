using System;

// Base class
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}

// SINGLE INHERITANCE
// Dog inherits Animal
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking");
    }
}

// MULTILEVEL INHERITANCE
// Puppy inherits Dog, and Dog inherits Animal
class Puppy : Dog
{
    public void Play()
    {
        Console.WriteLine("Puppy is playing");
    }
}

// Interfaces for MULTIPLE INHERITANCE
interface IWalk
{
    void Walk();
}

interface ISwim
{
    void Swim();
}

// A class implements two interfaces
class Human : IWalk, ISwim
{
    public void Walk()
    {
        Console.WriteLine("Human is walking");
    }

    public void Swim()
    {
        Console.WriteLine("Human is swimming");
    }
}

class Program
{
    static void Main()
    {
        // Single Inheritance
        Console.WriteLine("SINGLE INHERITANCE");
        Dog d = new Dog();
        d.Eat();
        d.Bark();

        // Multilevel Inheritance
        Console.WriteLine("\nMULTILEVEL INHERITANCE");
        Puppy p = new Puppy();
        p.Eat();
        p.Bark();
        p.Play();

        // Multiple Inheritance using Interfaces
        Console.WriteLine("\nMULTIPLE INHERITANCE");
        Human h = new Human();
        h.Walk();
        h.Swim();

        Console.ReadLine();
    }
}