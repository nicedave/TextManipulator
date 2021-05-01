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
        IAlgorithmsManager _algorithmsManager;
        public TextManipulatorsController(IAlgorithmsManager algorithmsManager)
        {
            _algorithmsManager = algorithmsManager;
        }

        public ActionResult Index()
        {
            var viewModel = InitFormViewModel();
            if (viewModel.AvailableAlgorithms.Count() == 1)
            {
                viewModel.SelectedAlgorithm = viewModel.AvailableAlgorithms.First();
            }
            return View("Index", viewModel);
        }

        public ActionResult Manipulate(TextManipulatorFormViewModel viewModel)
        {
            viewModel.AvailableAlgorithms = GetAvailableAlgorithms();

            if (!ModelState.IsValid)
            {
                return View("Index", viewModel);
            }

            var result = _algorithmsManager.ExecuteAlgorithm(viewModel.SelectedAlgorithm, viewModel.Text);
            viewModel.AlgorithmOutput = result;

            return View("Index", viewModel);
        }

        private TextManipulatorFormViewModel InitFormViewModel()
        {
            var viewModel = new TextManipulatorFormViewModel();
            viewModel.AvailableAlgorithms = GetAvailableAlgorithms();
            
            return viewModel;
        }
        private IEnumerable<string> GetAvailableAlgorithms()
        {
            return _algorithmsManager.GetAvailableAlgorithms();
        }
    }
}