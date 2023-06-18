namespace ShapeLib.Shapes;

public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Радиус должен быть положительным числом.");

        this.radius = radius;
    }

    /// <summary>
    /// Рассчитывает площадь круга
    /// </summary>
    /// <returns>Площадь круга</returns>
    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(radius, 2);
    }
}
