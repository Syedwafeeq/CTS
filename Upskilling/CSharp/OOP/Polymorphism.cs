using System;

class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows");
    }
}

class Polymorphism
{
    static void Main()
    {
        Animal animal;

        animal = new Dog();
        animal.MakeSound();

        animal = new Cat();
        animal.MakeSound();
    }
}
