using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TextManipulator.ViewModels;

namespace TextManipulator.Controllers
{
    public class TextManipulatorsController : Controller
    {
        IEnumerable<ITextManipulatorAlgorithm> _textManipulators;
        public TextManipulatorsController(IEnumerable<ITextManipulatorAlgorithm> textManipulators)
        {
            _textManipulators = textManipulators;
        }

        public ActionResult Index()
        {
            var viewModel = new TextManipulatorFormViewModel();
            viewModel.AvailableAlgorithms = GetAvailableAlgorithms();

            return View("Index", viewModel);
        }

        public ActionResult Manipulate(string text, string selectedAlgorithm)
        {
            //TODO: gestire selezione algoritmo e creazione viewmodel base
            ITextManipulatorAlgorithm algorithm = _textManipulators.SingleOrDefault(m => m.AlgorithmName == selectedAlgorithm);

            var manipulatedText = algorithm.ManipulateText(text);

            TextManipulatorFormViewModel viewModel = new TextManipulatorFormViewModel()
            {
                SelectedAlgorithm = algorithm.AlgorithmName,
                Text = text,
                ManipulatedText = manipulatedText,
                AvailableAlgorithms = GetAvailableAlgorithms()
            };

            return View("Index", viewModel);
        }

        private List<string> GetAvailableAlgorithms()
        {
            return _textManipulators.Select(m => m.AlgorithmName).ToList();
        }
    }
}