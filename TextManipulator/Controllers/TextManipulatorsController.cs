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
        ITextManipulatorAlgorithm _textManipulator;
        public TextManipulatorsController()
        {
            _textManipulator = new LargestWordFinder();
        }
        
        public ActionResult Index()
        {
            var viewModel = new TextManipulatorFormViewModel();
            viewModel.AvailableAlgorithms = GetAvailableAlgorithms();

            return View("Index", viewModel);
        }

        public ActionResult Manipulate(string text)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            var manipulatedText = _textManipulator.ManipulateText(text);
            TextManipulatorFormViewModel viewModel = new TextManipulatorFormViewModel()
            {
                SelectedAlgorithm = _textManipulator.AlgorithmName,
                Text = text,
                ManipulatedText = manipulatedText,
                AvailableAlgorithms = GetAvailableAlgorithms()
            };

            return View("Index", viewModel);
        }

        private List<string> GetAvailableAlgorithms() 
        {
            return new List<string>() { _textManipulator.AlgorithmName };
        }
    }
}