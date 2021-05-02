using Moq;
using NUnit.Framework;
using TextManipulator.Controllers;
using TextManipulator.Controllers.Algorithms;
using TextManipulator.ViewModels;

namespace TextManipulator.Tests.Controllers
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
        public void Index_WhenCalled_GetsAvailableAlgorithms() 
        {
            var result = _controller.Index();

            _manager.Verify(m => m.GetAvailableAlgorithms());
        }

        [Test]
        public void Manipulate_ViewModelIsValid_InvokesExecuteAlghoritms()
        {
            var viewmodel = new TextManipulatorFormViewModel() 
            {
                Text = "text",
                SelectedAlgorithm = "algo"
            };

            var result = _controller.Manipulate(viewmodel);

            _manager.Verify(m => m.ExecuteAlgorithm(viewmodel.SelectedAlgorithm, viewmodel.Text));
        }
    }
}
