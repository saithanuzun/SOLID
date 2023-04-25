/*
 * High-Level Modules/Classes should not depend on Low-Level Modules/Classes.
 * Both should depend upon Abstractions.
 * Secondly, Abstractions should not depend upon Details. Details should depend upon Abstractions.
 *
 * The most important point that you need to remember
 * while developing real-time applications is always to try to keep the High-level module and Low-level module as loosely coupled as possible.
 */


// High-level module interface

public interface IAnimal
{
    void MakeSound();
}

// Low-level module implementation
public class Dog : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
}

// High-level module implementation using dependency inversion
public class AnimalApp
{
    private readonly IAnimal _animal;

    public AnimalApp(IAnimal animal)
    {
        _animal = animal;
    }

    public void Run()
    {
        _animal.MakeSound();
    }
}