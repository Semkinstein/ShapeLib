using ShapeLib.Shapes;

namespace ShapeLib;

public static class ShapeCalculator
{
    /// <summary>
    /// Рассчитывает площадь любой фигуры наследника Shape
    /// </summary>
    /// <returns>Площадь типа double</returns>
    public static double CalculateArea(Shape shape)
    {
        return shape.CalculateArea();
    }
}
