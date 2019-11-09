using Microsoft.VisualStudio.TestTools.UnitTesting;
using FigureLib;
using System;

namespace UnitTestFigure
{
    [TestClass]
    public class UnitTestFigure
    {
        [TestMethod]
        public void ShouldCalcCircleArea()
        {
            // Arrange
            Figure figure = new Circle(5);
            double expectedArea = 78.5398;
            double eps = 0.0001;

            // Act
            var area = figure.Area();

            // Assert
            Assert.IsTrue(Math.Abs(expectedArea - area) < eps, $"exp: {expectedArea}, actual: {area}");
        }

        [TestMethod]
        public void ShouldThrowExceptionForNegativeRadius()
        {
            // Arrange
            Figure figure;

            // Act

            // Assert
            Assert.ThrowsException<FigureException>(() => figure = new Circle(-5));
        }


        [TestMethod]
        public void ShouldCalcTrangleArea()
        {
            // Arrange
            Figure figure = new Trangle(5, 4, 3);
            double expectedArea = 6;
            double eps = 0.00001;

            // Act
            var area = figure.Area();

            // Assert
            Assert.IsTrue(Math.Abs(expectedArea - area) < eps, $"exp: {expectedArea}, actual: {area}");
        }

        [TestMethod]
        public void ShouldThrowExceptionForNegativeSide()
        {
            // Arrange
            Figure figure;

            // Act

            // Assert
            Assert.ThrowsException<FigureException>(() => figure = new Trangle(5, -4, 3));
        }

        [TestMethod]
        public void ShouldThrowExceptionForIncorrectTrangle()
        {
            // Arrange
            Figure figure;

            // Act

            // Assert
            Assert.ThrowsException<FigureException>(() => figure = new Trangle(5, 4, 1));
        }

        [TestMethod]
        public void ShouldRewriteInstance()
        {
            // Arrange
            Figure figure;

            // Act1
            figure = new Circle(5);
            // Assert1
            Assert.IsInstanceOfType(figure, typeof(Circle));

            // Act2
            figure = new Trangle(5, 4, 3);
            // Assert2
            Assert.IsInstanceOfType(figure, typeof(Trangle));
        }


        [TestMethod]
        [DataRow(5, 4, 3, true)]
        [DataRow(5, 3, 3, false)]
        public void ShouldCheckRectTrangle(int a, int b, int c, bool exp)
        {
            // Arrange
            Figure figure = new Trangle(a, b, c);

            // Act
            if (figure is Trangle trangle)
            {
                var act = (figure as Trangle)?.IsRectAngle();
                // Assert
                Assert.AreEqual(exp, act);
            }
            else {
                Assert.ThrowsException<FigureException>(() => throw new FigureException($"This instance isn't trangle, {nameof(figure)}"));
            }
        }
    }
}
