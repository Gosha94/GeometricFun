using GeometricFun.Figures.Errors;
using GeometricFun.Figures.Abstractions;

namespace GeometricFun.Figures.Entities;

public sealed class Circle : Figure
{

    private Circle(double area)
        : base(area)
    { }

    /// <summary>
    /// Method for creating a Circle figure
    /// </summary>
    /// <param name="radius">Radius of a Circle</param>
    /// <returns></returns>
    /// <exception cref="ArgumentException">When Circle Radius Below The Zero</exception>
    public static Circle Create(double radius)
    {
        if (radius <= 0.0)
        {
            var error = DomainErrors.CircleRadiusBelowTheZero;
            
            throw new ArgumentException(
                $"{error.Code} - {error.Message}");
        }

        var circleArea = Math.PI * Math.Pow(radius, 2);
        
        return new Circle(circleArea);
    }
    
}