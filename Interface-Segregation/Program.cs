/*
 * Interface Segregation Principle (ISP) states
 * that clients should not be forced to depend on interfaces they do not use.
 * In simpler terms, it means that a class should not be required to implement an interface
 * if it does not need all the methods declared in that interface.
 */
public interface IDrivable
{
    void Start();
    void Stop();
    void Accelerate();
    void TurnLeft();
    void TurnRight();
}

public interface IRefuelable
{
    void Refuel();
}

public class Car : IDrivable, IRefuelable
{
    public void Start()
    {
        // implementation
    }

    public void Stop()
    {
        // implementation
    }

    public void Accelerate()
    {
        // implementation
    }

    public void TurnLeft()
    {
        // implementation
    }

    public void TurnRight()
    {
        // implementation
    }

    public void Refuel()
    {
        // implementation
    }
}

public class Motorcycle : IDrivable
{
    public void Start()
    {
        // implementation
    }

    public void Stop()
    {
        // implementation
    }

    public void Accelerate()
    {
        // implementation
    }

    public void TurnLeft()
    {
        // implementation
    }

    public void TurnRight()
    {
        // implementation
    }
}