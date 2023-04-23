/*
 * A software module or class should have one-and-only reason to change.
 * A class should have one-and-only reason to change.
 * A class should implement only one functionality.
 * Avoid multiple / tightly coupled functionalities in a single class.
 * !!! Do not repeat yourself!
 */


// this class violates single responsibility principle
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    public void Save()
    {
        // save employee details to database
    }

    public void SendEmail(string message)
    {
        // send email to employee
    }
}

// you should use separate classes for each action
public class Employee2
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}

public class EmployeeRepository
{
    public void Save(Employee2 employee)
    {
        // save employee details to database
    }
}

public class EmailService
{
    public void SendEmail(Employee2 employee, string message)
    {
        // send email to employee
    }
}
