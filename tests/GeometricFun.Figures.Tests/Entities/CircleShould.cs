using Xunit;
using FluentAssertions;
using GeometricFun.Figures.Entities;

namespace GeometricFun.Figures.Tests.Entities;

public class CircleShould
{
    [Theory]
    [InlineData(55.0, 9503.318)]
    [InlineData(22.0, 1520.531)]
    [InlineData(1.2345, 4.788)]
    public void Create_WithCorrectRadius__AreaShouldBeCorrect(
        double radiusCase,
        double expectedRadius)
    {
        // Arrange
        var sut = Circle.Create(radiusCase);

        // Act
        var actualRadius = sut.Area;

        // Assert
        Assert.Equal(expectedRadius, actualRadius);

    }

    [Theory]
    [InlineData(-0.5)]
    [InlineData(-22.0)]
    public void Create_WithCircleRadiusBelowTheZero_ThrowsAnArgumentException(
        double radiusCase)
    {
        // Arrange
        // Act

        // Assert
        Assert.Throws<ArgumentException>(() => Circle.Create(radiusCase));
    }
}