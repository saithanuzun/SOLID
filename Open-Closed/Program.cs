/* Open-Closed
 * Open for Extension, Closed for Modification
 * you should not change the method or class instead of this,
 * you should be able create new classes or method without modified old one
 * 
 */

public abstract class Shape
{
    public abstract double Area();

}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double Area()
    {
        return Width * Height;
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public override double Area()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

public class AreaCalculator
{
    public double TotalArea(Shape[] shapes)
    {
        double area = 0;
        foreach (var shape in shapes)
        {
            area += shape.Area();
        }
        return area;
    }
}

// we want to add a new shape, such as a triangle.
// We can do so without modifying the existing code by creating a new Triangle class
// that inherits from the Shape class and overrides the Area method:

public class Triangle : Shape
{
    public double Base { get; set; }
    public double Height { get; set; }

    public override double Area()
    {
        return (Base * Height) / 2;
    }
}

// another example

public class Invoice
{
    public virtual double GetInvoiceDiscount(double amount)
    {
        return amount - 10;
    }
}
    
public class FinalInvoice : Invoice
{
    public override double GetInvoiceDiscount(double amount)
    {
        return base.GetInvoiceDiscount(amount) - 50;
    }
}
public class ProposedInvoice : Invoice
{
    public override double GetInvoiceDiscount(double amount)
    {
        return base.GetInvoiceDiscount(amount) - 40;
    }
}
public class RecurringInvoice : Invoice
{
    public override double GetInvoiceDiscount(double amount)
    {
        return base.GetInvoiceDiscount(amount) - 30;
    }
}
