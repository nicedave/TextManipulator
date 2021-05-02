using Moq;
using NUnit.Framework;
using TextManipulator.Controllers.Algorithms;
using TextManipulator.Controllers.Api;

namespace TextManipulator.Tests.Controllers.Api
{
    [TestFixture]
    public class TextManipulatorsControllerTests
    {
        Mock<IAlgorithmsManager> _manager;
        TextManipulatorsController _controller;

        [SetUp]
        public void SetUp()
        {
            _manager = new Mock<IAlgorithmsManager>();
            _controller = new TextManipulatorsController(_manager.Object);    
        }

        [Test]
        public void GetAvailableAlgorithms_WhenCalled_InvokesAlgorithmManager() 
        {
            _controller.GetAvailableAlgorithms();

            _manager.Verify(m => m.GetAvailableAlgorithms());
        }

        [Test]
        public void ExecuteAllAlgorithms_WhenCalled_InvokesAlgorithmManager()
        {
            string text = "text";
            _controller.ExecuteAllAlgorithms(text);

            _manager.Verify(m => m.ExecuteAllAlgorithms(text));
        }

        [Test]
        public void ExecuteAllAlgorithms_WhenCalled_ExecuteAlgorithm()
        {
            string text = "text";
            string algorithm = "algo";

            _controller.ExecuteAlgorithm(algorithm, text);

            _manager.Verify(m => m.ExecuteAlgorithm(algorithm, text));
        }
    }
}
