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
    }
}