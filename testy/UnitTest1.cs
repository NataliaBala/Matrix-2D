/*using System;
using NUnit.Framework;
using MatrixLibrary;

namespace MatrixLibrary.Tests
{
    [TestFixture]
    public class Matrix2DTests
    {
        [Test]
        public void Constructor_WithParameters_CreatesMatrixWithCorrectValues()
        {
            Matrix2D matrix = new Matrix2D(1, 2, 3, 4);

            Assert.AreEqual(1, matrix.A);
            Assert.AreEqual(2, matrix.B);
            Assert.AreEqual(3, matrix.C);
            Assert.AreEqual(4, matrix.D);
        }

        [Test]
        public void Constructor_Default_CreatesIdentityMatrix()
        {
            Matrix2D matrix = new Matrix2D();

            Assert.AreEqual(Matrix2D.Id, matrix);
        }

        [Test]
        public void ToString_ReturnsCorrectStringRepresentation()
        {
            Matrix2D matrix = new Matrix2D(1, 2, 3, 4);

            Assert.AreEqual("[[1, 2], [3, 4]]", matrix.ToString());
        }

        [Test]
        public void Parse_ValidString_ReturnsCorrectMatrix()
        {
            Matrix2D matrix = Matrix2D.Parse("[[1, 2], [3, 4]]");

            Assert.AreEqual(new Matrix2D(1, 2, 3, 4), matrix);
        }

        [Test]
        public void Parse_InvalidString_ThrowsFormatException()
        {
            Assert.Throws<FormatException>(() => Matrix2D.Parse("[[1, 2] [3, 4]]"));
        }

        [Test]
        public void Equals_TwoEqualMatrices_ReturnsTrue()
        {
            Matrix2D matrix1 = new Matrix2D(1, 2, 3, 4);
            Matrix2D matrix2 = new Matrix2D(1, 2, 3, 4);

            Assert.IsTrue(matrix1.Equals(matrix2));
        }

        [Test]
        public void NotEquals_TwoDifferentMatrices_ReturnsTrue()
        {
            Matrix2D matrix1 = new Matrix2D(1, 2, 3, 4);
            Matrix2D matrix2 = new Matrix2D(2, 3, 4, 5);

            Assert.IsTrue(matrix1 != matrix2);
        }
    }
}
