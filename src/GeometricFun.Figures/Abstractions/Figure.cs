namespace GeometricFun.Figures.Abstractions;

/// <summary>
/// An abstract class that represents simple Geometric figure
/// </summary>
public abstract class Figure
{
    private readonly double _area;

    protected internal Figure(double area)
    {
        _area = area;
    }

    /// <summary>
    /// Figure's area property 
    /// </summary>
    public double Area
    {
        get => Math.Round(_area, 3);
    }
}