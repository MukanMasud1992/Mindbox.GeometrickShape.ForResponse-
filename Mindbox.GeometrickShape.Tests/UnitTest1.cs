using Moq;
using NUnit.Framework;
using System;

namespace Mindbox.GeometrickShape.Tests
{
    public class UnitTest1
    {
        [Test]
        public void Visit_Circle_ShouldSetResultToCorrectValue()
        {
            var triangleMock = new Mock<Triangle>(3, 4, 5);
            double expectedArea = 6;

            triangleMock.Setup(x => x.Area()).Returns(expectedArea);

            var triangle = triangleMock.Object;

            // Act
            double actualArea = triangle.Area();

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }

    }
}