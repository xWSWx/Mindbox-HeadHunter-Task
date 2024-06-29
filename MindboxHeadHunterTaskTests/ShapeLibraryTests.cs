using MindboxHeadHunterTask;
using NUnit.Framework;
using System;

namespace ShapeLibraryTests
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void CalculateArea_ValidRadius_ReturnsCorrectArea()
        {
            var circle = new Circle(5);
            double expectedArea = Math.PI * 25;
            Assert.That(circle.CalculateArea(), Is.EqualTo(expectedArea).Within(1e-10));
        }

        [Test]
        public void Constructor_NegativeRadius_ThrowsArgumentException()
        {
            Assert.That(() => new Circle(-5), Throws.ArgumentException);
        }
    }

    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void CalculateArea_ValidSides_ReturnsCorrectArea()
        {
            var triangle = new Triangle(3, 4, 5);
            double expectedArea = 6; // Known area for 3-4-5 triangle
            Assert.That(triangle.CalculateArea(), Is.EqualTo(expectedArea).Within(1e-10));
        }

        [Test]
        public void Constructor_NegativeSideA_ThrowsArgumentException()
        {
            Assert.That(() => new Triangle(-3, 4, 5), Throws.ArgumentException);
        }

        [Test]
        public void Constructor_NegativeSideB_ThrowsArgumentException()
        {
            Assert.That(() => new Triangle(3, -4, 5), Throws.ArgumentException);
        }

        [Test]
        public void Constructor_NegativeSideC_ThrowsArgumentException()
        {
            Assert.That(() => new Triangle(3, 4, -5), Throws.ArgumentException);
        }

        [Test]
        public void Constructor_InvalidTriangle_ThrowsArgumentException()
        {
            Assert.That(() => new Triangle(1, 2, 3.1), Throws.ArgumentException);
        }

        [Test]
        public void IsRectangular_ValidRectangularTriangle_ReturnsTrue()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.That(triangle.IsRectangular(), Is.True);
        }

        [Test]
        public void IsRectangular_NonRectangularTriangle_ReturnsFalse()
        {
            var triangle = new Triangle(3, 3, 3);
            Assert.That(triangle.IsRectangular(), Is.False);
        }
    }
}
