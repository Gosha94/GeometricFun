namespace GeometricFun.Figures.Errors;

internal static class DomainErrors
{
    internal static readonly Error CircleRadiusBelowTheZero = new Error(
        "GeometricFun.Figures.Circle.CircleRadiusBelowTheZero",
        "Radius of the circle must be a positive double.");

    internal static readonly Error TriangleSideNotPositive = new Error(
        "GeometricFun.Figures.Triangle.TriangleSideNotPositive",
        "Each side must be a positive double.");

    internal static readonly Error FigureIsNotTriangle = new Error(
        "GeometricFun.Figures.Triangle.FigureIsNotTriangle",
        "The sides don't form a triangle.");
}