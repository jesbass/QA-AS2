
using NUnit.Framework;
using QA_AS2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UnitTests
{
    public class Tests
    {

        [Test]
        public void SetLength_Integer_Value()
        {
            var rectangle = new Rectangle();
            var result = rectangle.SetLength(1);
            Assert.IsInstanceOf<int>(result);
        }

        [Test]
        public void SetWidth_Integer_Value()
        {
            var rectangle = new Rectangle();
            var result = rectangle.SetWidth(1);
            Assert.IsInstanceOf<int>(result);
        }

        [Test]
        public void SetLength_Default()
        {
            var rectangle = new Rectangle();
            int testValue = 1;
            var result = rectangle.SetLength(testValue);
            Assert.AreEqual(testValue, result);
        }

        [Test]
        public void SetLength_Value()
        {
            var rectangle = new Rectangle();
            var testLength = 3;
            var result = rectangle.SetLength(testLength);
            Assert.AreEqual(testLength, result);
        }

        [Test]
        public void GetLength_Default()
        {
            var rectangle = new Rectangle();
            var result = rectangle.GetLength();
            Assert.AreEqual(1, result);
        }

        [Test]
        public void GetLength_Value()
        {
            var rectangle = new Rectangle();
            var result = rectangle.GetLength();
            Assert.AreEqual(rectangle.GetLength(), result);
        }

        [Test]
        public void SetWidth_Default()
        {
            var rectangle = new Rectangle();
            int testValue = 1;
            var result = rectangle.SetWidth(testValue);
            Assert.AreEqual(testValue, result);
        }
        [Test]
        public void SetWidth_Value()
        {
            var rectangle = new Rectangle();
            var testWidth = 3;
            var result = rectangle.SetWidth(testWidth);
            Assert.AreEqual(testWidth, result);
        }

        [Test]
        public void GetWidth_Value()
        {
            var rectangle = new Rectangle();
            var result = rectangle.GetWidth();
            Assert.AreEqual(rectangle.GetWidth(), result);
        }

        [Test]
        public void GetWidth_Default()
        {
            var rectangle = new Rectangle();
            var result = rectangle.GetWidth();
            Assert.AreEqual(1, result);
        }

        [Test]
        public void GetArea_Default()
        {
            var rectangle = new Rectangle();
            var result = rectangle.GetArea();
            Assert.AreEqual(1, result);
        }

        [Test]
        public void GetArea_Change_Value()
        {
            int testLength = 3;
            int testWidth = 5;
            var rectangle = new Rectangle();
            rectangle.SetLength(testLength);
            rectangle.SetWidth(testWidth);
            var expectedArea = testWidth * testLength;
            var resultArea = rectangle.GetArea();
            Assert.AreEqual(expectedArea, resultArea);
        }

        [Test]
        public void GetPerimeter_Change_Value()
        {
            int testLength = 4;
            int testWidth = 5;
            var rectangle = new Rectangle();
            rectangle.SetLength(testLength);
            rectangle.SetWidth(testWidth);
            var expectedPerimeter = (testWidth * 2) + (testLength * 2);
            var resultPerimeter = rectangle.GetPerimeter();
            Assert.AreEqual(expectedPerimeter, resultPerimeter);
        }

        [Test]
        public void GetPerimeter_Default()
        {
            var rectangle = new Rectangle();
            var result = rectangle.GetPerimeter();
            Assert.AreEqual(4, result);
        }
    }
}
