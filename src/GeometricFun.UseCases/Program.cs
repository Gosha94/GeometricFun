using GeometricFun.Figures.Entities;
using GeometricFun.Figures.Abstractions;

namespace GeometricFun.UseCases;

internal class Program
{
    static void Main(string[] args)
    {
        var figures = new List<Figure>();
        var triangle = Triangle.Create(22.0, 33.0, 44.0);
        var circle = Circle.Create(2);

        figures.Add(circle);
        figures.Add(triangle);

        foreach (var figure in figures)
        {
            Console.WriteLine($"figure: {nameof(figure)}, area: {figure.Area}");
        }
    }
}