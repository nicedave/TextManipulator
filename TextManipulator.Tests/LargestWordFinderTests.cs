using NUnit.Framework;
using TextManipulator.Controllers;

namespace TextManipulator.Tests
{
    [TestFixture]
    public class LargestWordFinderTests
    {
        private LargestWordFinder _algorithm;
        [SetUp]
        public void SetUp()
        {
            _algorithm = new LargestWordFinder();
        }

        [Test]
        [TestCase("a b c d", "a")]
        [TestCase("a b c dddd", "dddd")]
        [TestCase("a b c dddd eeee f g", "dddd")]
        public void ManipulateString_WhenCalled_ReturnsFirstLargestWord(string text, string expectedResult)
        {
            var output = _algorithm.ManipulateText(text);

            Assert.That(output.Result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void ManipulateString_WhenCalled_ReturnsAlgorithmName()
        {
            var output = _algorithm.ManipulateText("a");

            Assert.That(output.AlgorithmName, Is.EqualTo(_algorithm.AlgorithmName));
        }
    }
}
