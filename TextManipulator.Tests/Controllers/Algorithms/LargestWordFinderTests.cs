using NUnit.Framework;
using TextManipulator.Controllers.Algorithms;

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
        [TestCase("a b c longest", "longest")]
        [TestCase("a b c longest samelen f g", "longest")]
        public void ManipulateString_TextIsValid_ReturnsFirstLargestWord(string text, string expectedResult)
        {
            var output = _algorithm.ManipulateText(text);

            Assert.That(output.Result, Is.EqualTo(expectedResult));
        }

        [Test]
        [Ignore("Not mandatory for the test")]
        public void ManipulateString_TextIsNull_ReturnsEmptyResult()
        {
            var output = _algorithm.ManipulateText(null);

            Assert.That(output.Result, Is.EqualTo(""));
        }

        [Test]
        public void ManipulateString_WhenCalled_ReturnsAlgorithmName()
        {
            var output = _algorithm.ManipulateText("a");

            Assert.That(output.AlgorithmName, Is.EqualTo(_algorithm.AlgorithmName));
        }
    }
}
