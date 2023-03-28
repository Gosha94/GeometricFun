using GeometricFun.Figures.Errors;
using GeometricFun.Figures.Abstractions;

namespace GeometricFun.Figures.Entities;

public sealed class Triangle : Figure
{

    public double[] Sides { get; }

    private Triangle(double[] sides, double area)
        : base(area)
    {
        Sides = sides;
    }

    /// <summary>
    /// Method for creating a Triangle figure
    /// </summary>
    /// <param name="sideA">A side length of a triangle</param>
    /// <param name="sideB">B side length of a triangle</param>
    /// <param name="sideC">C side length of a triangle</param>
    /// <returns>Triangle figure</returns>
    /// <exception cref="ArgumentException">When Triangle Side Not Positive and Figure Is Not Triangle</exception>
    public static Triangle Create(double sideA, double sideB, double sideC)
    {

        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
        {
            var error = DomainErrors.TriangleSideNotPositive;
            throw new ArgumentException(
                $"{error.Code} - {error.Message}");
        }
        
        if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
        {
            var error = DomainErrors.FigureIsNotTriangle;
            throw new ArgumentException(
                $"{error.Code} - {error.Message}");
        }

        var P = sideA + sideB + sideC;
        var halfP = P / 2;
        var S = Math.Sqrt(halfP * (halfP - sideA) * (halfP - sideB) * (halfP - sideC));

        double[] sides = new[] { sideA, sideB, sideC };

        return new Triangle(sides, S);
    }

    /// <summary>
    /// Method checks triangle for having a 90 percent angle
    /// </summary>
    /// <param name="triangle">Triangle for check</param>
    /// <returns>bool flag that shows has triangle 90 percent angle or not</returns>
    public static bool HasRightAngle(Triangle triangle)
    {
        var decimalPointPrecision = 2;

        Array.Sort(triangle.Sides);

        var rightHypotenuse = Math.Sqrt(
            Math.Pow(triangle.Sides[0], 2) + Math.Pow(triangle.Sides[1], 2));

        var delta = Math.Round(
            Math.Abs(rightHypotenuse - triangle.Sides[2]), decimalPointPrecision);

        return delta <= 0.0;
    }

}