using System;
using Xunit;

public class TriangleIdentifierTests
{
    [Fact]
    public void IdentifyTriangleType_EquilateralTriangle_ReturnsEquilateral()
    {
        // Arrange
        var triangleIdentifier = new TriangleIdentifier();
        double side1 = 5.0;
        double side2 = 5.0;
        double side3 = 5.0;

        // Act
        TriangleType type = triangleIdentifier.IdentifyTriangleType(side1, side2, side3);

        // Assert
        Assert.Equal(TriangleType.Equilateral, type);
    }

    [Fact]
    public void IdentifyTriangleType_IsoscelesTriangle_ReturnsIsosceles()
    {
        // Arrange
        var triangleIdentifier = new TriangleIdentifier();
        double side1 = 4.0;
        double side2 = 4.0;
        double side3 = 5.0;

        // Act
        TriangleType type = triangleIdentifier.IdentifyTriangleType(side1, side2, side3);

        // Assert
        Assert.Equal(TriangleType.Isosceles, type);
    }

    [Fact]
    public void IdentifyTriangleType_ScaleneTriangle_ReturnsScalene()
    {
        // Arrange
        var triangleIdentifier = new TriangleIdentifier();
        double side1 = 3.0;
        double side2 = 4.0;
        double side3 = 5.0;

        // Act
        TriangleType type = triangleIdentifier.IdentifyTriangleType(side1, side2, side3);

        // Assert
        Assert.Equal(TriangleType.Scalene, type);
    }

    [Fact]
    public void IdentifyTriangleType_InvalidSides_ThrowsArgumentException()
    {
        // Arrange
        var triangleIdentifier = new TriangleIdentifier();
        double side1 = -1.0;
        double side2 = 2.0;
        double side3 = 3.0;

        // Act and Assert
        Assert.Throws<ArgumentException>(() => triangleIdentifier.IdentifyTriangleType(side1, side2, side3));
    }
}
