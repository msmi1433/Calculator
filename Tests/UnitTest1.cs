using NuGet.Frameworks;
using Sandbox;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void AddPassingTest()
        {
            Assert.That(Calculator.Add(2,2), Is.EqualTo(4));
        }

        [Test]
        public void AddFailingTest()
        {
            Assert.That(Calculator.Add(2,2), Is.EqualTo(5));
        }

        [Test]
        public void SubtractPassingTest()
        {
            Assert.That(Calculator.Subtract(3, 1), Is.EqualTo(2));
        }

        [Test]
        public void SubtractFailingTest()
        {
            Assert.That(Calculator.Subtract(4, 3), Is.EqualTo(2));
        }
        
        [Test]
        public void MultiplyPassingTest()
        {
            Assert.That(Calculator.Multiply(3, 1), Is.EqualTo(3));
        }
        
        [Test]
        public void MultiplyFailingTest()
        {
            Assert.That(Calculator.Multiply(3, 1), Is.EqualTo(5));
        }

        [Test]
        public void DividePassingTest()
        {
            Assert.That(Calculator.Divide(6, 2), Is.EqualTo(3));
        }
        [Test]
        public void DivideFailingTest()
        {
            Assert.That(Calculator.Divide(6, 2), Is.EqualTo(5));
        }
    }
}