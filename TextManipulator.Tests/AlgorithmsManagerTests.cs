using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using TextManipulator.Controllers;

namespace TextManipulator.Tests
{
    [TestFixture]
    public class AlgorithmsManagerTests
    {
        AlgorithmsManager _manager;

        [SetUp]
        public void SetUp()
        {
            var algorithms = new List<ITextManipulatorAlgorithm>();

            var firstAlgorithm = new Mock<ITextManipulatorAlgorithm>();
            firstAlgorithm.Setup(f => f.AlgorithmName).Returns("First");
            firstAlgorithm.Setup(f => f.ManipulateText("FirstInput")).Returns(new DTOs.AlgorithmOutputDTO() { Result = "FirstResult" });

            var secondAlgorithm = new Mock<ITextManipulatorAlgorithm>();
            secondAlgorithm.Setup(f => f.AlgorithmName).Returns("Second");
            secondAlgorithm.Setup(f => f.ManipulateText("SecondInput")).Returns(new DTOs.AlgorithmOutputDTO() { Result = "SecondResult" });

            algorithms.Add(firstAlgorithm.Object);
            algorithms.Add(secondAlgorithm.Object);

            _manager = new AlgorithmsManager(algorithms);
        }

        [Test]
        public void GetAvailableAlgorithms_WhenCalled_ReturnAllAlgorithmsName() 
        {
            var output = _manager.GetAvailableAlgorithms();
            Assert.That(output, Is.EqualTo(new[] { "First", "Second" }));
        }

        [Test]
        [TestCase("First", "FirstInput", "FirstResult")]
        [TestCase("Second", "SecondInput", "SecondResult")]
        public void ExecuteAlgorithm_WhenCalled_ExecutesCorrectAlgorithm(string algorithmName, string input, string expectedResult)
        {
            var output = _manager.ExecuteAlgorithm(algorithmName, input);
            Assert.That(output.Result, Is.EqualTo(expectedResult));
        }
    }
}
