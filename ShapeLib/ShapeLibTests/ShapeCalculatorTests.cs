using NUnit.Framework;
using ShapeLib.Shapes;
using ShapeLib;


namespace ShapeLibTests;

[TestFixture]
public class ShapeCalculatorTests
{
    [Test]
    public void CalculateCircleArea_ValidRadius_ReturnsCorrectArea()
    {
        // Arrange
        double radius = 5;
        double expectedArea = Math.PI * Math.Pow(radius, 2);
        Shape circle = new Circle(radius);

        // Act
        double actualArea = ShapeCalculator.CalculateArea(circle);

        // Assert
        Assert.AreEqual(expectedArea, actualArea);
    }

    [Test]
    public void CalculateCircleArea_NegativeRadius_ThrowsArgumentException()
    {
        // Arrange
        double radius = -5;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }

    [Test]
    public void CalculateCircleArea_ZeroRadius_ThrowsArgumentException()
    {
        // Arrange
        double radius = 0;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }

    [Test]
    public void CalculateTriangleArea_ValidSides_ReturnsCorrectArea()
    {
        // Arrange
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;
        double expectedArea = 6;
        Shape triangle = new Triangle(sideA, sideB, sideC);

        // Act
        double actualArea = ShapeCalculator.CalculateArea(triangle);

        // Assert
        Assert.AreEqual(expectedArea, actualArea);
    }

    [Test]
    public void CalculateTriangleArea_NegativeSide_ThrowsArgumentException()
    {
        // Arrange
        double sideA = 3;
        double sideB = -4;
        double sideC = 5;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
    }

    [Test]
    public void CalculateTriangleArea_ZeroSide_ThrowsArgumentException()
    {
        // Arrange
        double sideA = 3;
        double sideB = 4;
        double sideC = 0;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
    }

    [Test]
    public void IsRight_Right_ReturnsTrue()
    {
        // Arrange
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;
        var triangle = new Triangle(sideA, sideB, sideC);

        // Act & Assert
        Assert.IsTrue(triangle.IsRight);
    }

    [Test]
    public void IsRight_NotRight_ReturnsFalse()
    {
        // Arrange
        double sideA = 3;
        double sideB = 4;
        double sideC = 6;
        var triangle = new Triangle(sideA, sideB, sideC);

        // Act & Assert
        Assert.IsFalse(triangle.IsRight);
    }
}
