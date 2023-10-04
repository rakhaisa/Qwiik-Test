using System;

public enum TriangleType
{
    Equilateral,
    Isosceles,
    Scalene
}

public class TriangleIdentifier
{
    public TriangleType IdentifyTriangleType(double side1, double side2, double side3)
    {
        if (side1 <= 0 || side2 <= 0 || side3 <= 0)
        {
            throw new ArgumentException("Side lengths must be greater than zero.");
        }

        if (side1 == side2 && side2 == side3)
        {
            return TriangleType.Equilateral;
        }
        else if (side1 == side2 || side1 == side3 || side2 == side3)
        {
            return TriangleType.Isosceles;
        }
        else
        {
            return TriangleType.Scalene;
        }
    }
}

/*public partial class Program
{
    public static void Main()
    {
        double side1, side2, side3;
        
        Console.Write("Enter the length of side 1: ");
        side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side 2: ");
        side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side 3: ");
        side3 = Convert.ToDouble(Console.ReadLine());

        var triangleIdentifier = new TriangleIdentifier();
        TriangleType type = triangleIdentifier.IdentifyTriangleType(side1, side2, side3);

        Console.WriteLine($"The triangle is of type: {type}");
    }
}*/
