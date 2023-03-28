using Xunit;
using FluentAssertions;
using GeometricFun.Figures.Entities;

namespace GeometricFun.Figures.Tests.Entities;

public class TriangleShould
{
    [Theory]
    [InlineData(1.2, 1.3, 1.4, new [] {1.2, 1.3, 1.4})]
    [InlineData(22.0, 33.0, 44.0, new[] { 22.0, 33.0, 44.0 })]
    [InlineData(1.22222, 1.33333, 1.44444, new[] { 1.22222, 1.33333, 1.44444 })]
    public void Create_WithCorrectSides_HaveThreeSides(
        double sideA,
        double sideB,
        double sideC,
        double[] expectedSidesArr)
    {
        // Arrange
        var sut = Triangle.Create(sideA, sideB, sideC);

        // Act
        var actualSidesArr = sut.Sides;

        // Assert
        actualSidesArr.Should().BeEquivalentTo(expectedSidesArr);

    }

    [Theory]
    [InlineData(-0.5, 1.3, 1.4)]
    [InlineData(1.2, -0.5, 1.4)]
    [InlineData(1.2, 1.3, -0.5)]
    public void Create_WithOneNegativeSide_ThrowsAnArgumentException(
        double sideA,
        double sideB,
        double sideC)
    {
        // Arrange
        // Act

        // Assert
        Assert.Throws<ArgumentException>(() => Triangle.Create(sideA, sideB, sideC));
    }

    [Theory]
    [InlineData(0.5, 0.5, 1.4)]
    [InlineData(0.5, 1.5, 0.5)]
    [InlineData(1.2, 0.5, 0.5)]
    public void Create_NotTriangleFigure_ThrowsAnArgumentException(
        double sideA,
        double sideB,
        double sideC)
    {
        // Arrange
        // Act

        // Assert
        Assert.Throws<ArgumentException>(() => Triangle.Create(sideA, sideB, sideC));
    }

    [Theory]
    [InlineData(1.2, 1.3, 1.4, 0.723)]
    [InlineData(22.0, 33.0, 44.0, 351.473)]
    [InlineData(1.22222, 1.33333, 1.44444, 0.759)]
    public void Create_WithCorrectSides_AreaShouldBeCorrect(
        double sideA,
        double sideB,
        double sideC,
        double expectedResult)
    {
        // Arrange
        var sut = Triangle.Create(sideA, sideB, sideC);

        // Act
        var actualResult = sut.Area;

        // Assert
        Assert.Equal(actualResult, expectedResult);
    }

    [Theory]
    [InlineData(3.0, 4.0, 5.0, true)]
    [InlineData(4.5, 7.8, 9.00, true)]
    [InlineData(7.888, 9.44, 12.30, true)]
    public void HasRightAngle_WithOneNinetyPercentAngleSide_ReturnsTrue(
        double sideA,
        double sideB,
        double sideC,
        bool expectedResult)
    {
        // Arrange
        var sut = Triangle.Create(sideA, sideB, sideC);

        // Act
        var actualResult = Triangle.HasRightAngle(sut);

        // Assert
        Assert.Equal(expectedResult, actualResult);

    }

    [Theory]
    [InlineData(3.0, 4.0, 4.5, false)]
    [InlineData(4.5, 7.8, 8.00, false)]
    [InlineData(7.888, 9.44, 11.30, false)]
    public void HasRightAngle_WithoutSomeNinetyPercentAngleSides_ReturnsFalse(
        double sideA,
        double sideB,
        double sideC,
        bool expectedResult)
    {
        // Arrange
        var sut = Triangle.Create(sideA, sideB, sideC);

        // Act
        var actualResult = Triangle.HasRightAngle(sut);

        // Assert
        Assert.Equal(expectedResult, actualResult);
    }

}