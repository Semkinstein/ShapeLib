namespace ShapeLib.Shapes;

public class Triangle : Shape
{
    private double _sideA;
    private double _sideB;
    private double _sideC;

    public bool IsRight => IsRightTriangle();

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            throw new ArgumentException("Длины сторон треугольника должны быть положительными числами.");

        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
    }

    /// <summary>
    /// Рассчитывает площадь треугольника
    /// </summary>
    /// <returns>Площадь треугольника</returns>
    public override double CalculateArea()
    {
        double s = (_sideA + _sideB + _sideC) / 2;
        return Math.Sqrt(s * (s - _sideA) * (s - _sideB) * (s - _sideC));
    }

    /// <summary>
    /// Определяет является ли треугольник прямоугольным
    /// </summary>
    /// <returns>bool определяющий прямоугольность</returns>
    private bool IsRightTriangle()
    {
        double maxSide = Math.Max(Math.Max(_sideA, _sideB), _sideC);

        if (maxSide == _sideA)
        {
            return Math.Pow(_sideA, 2) == Math.Pow(_sideB, 2) + Math.Pow(_sideC, 2);
        }
        else if (maxSide == _sideB)
        {
            return Math.Pow(_sideB, 2) == Math.Pow(_sideA, 2) + Math.Pow(_sideC, 2);
        }
        else
        {
            return Math.Pow(_sideC, 2) == Math.Pow(_sideA, 2) + Math.Pow(_sideB, 2);
        }
    }
}
