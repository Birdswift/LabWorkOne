using Xunit;

namespace LabWorkOne
{
    public class FigureTests
    {
        [Fact]
        public void PerimeterCalculator_Triangle_ReturnsCorrectPerimeter()
        {
            // Arrange
            Point A = new Point(0, 0);
            Point B = new Point(0, 5);
            Point C = new Point(5, 5);
            Figure triangle = new Figure(A, B, C, "Треугольник");

            // Act
            double len1 = triangle.LengthSide(B, C);

            // Assert
            Assert.Equal(15, len1);
        }

        [Fact]
        public void PerimeterCalculator_Rectangle_ReturnsCorrectPerimeter()
        {
            // Arrange
            Point A = new Point(0, 0);
            Point B = new Point(0, 5);
            Point C = new Point(5, 5);
            Point D = new Point(5, 0);
            Figure rectangle = new Figure( A, B, C, D, "Прямоугольник");

            // Act
            double perimeter = rectangle.LengthSide(C, D);

            // Assert
            Assert.Equal(20, perimeter);
        }
    }
}