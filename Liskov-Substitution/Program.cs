/*
 * a subclass should be able to replace its parent class without affecting the correctness of the program.
 * This principle is essential for creating maintainable and extensible code,
 * as it ensures that code written for a base class can be reused for any of its derived classes.
 */

class Program
{
    public static void Main()
    {
        
        Animal[] animals = new Animal[] { new Dog(), new Cat() };

        foreach (Animal animal in animals)
        {
            animal.MakeSound();
        }

    }
}

class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic animal sound");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark!");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
}



