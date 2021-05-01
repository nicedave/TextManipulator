using System.Collections.Generic;
using System.Web.Http;

namespace TextManipulator.Controllers.Api
{
    public class TextManipulatorsController : ApiController
    {
        IAlgorithmsManager _algorithmsManager;
        public TextManipulatorsController(IAlgorithmsManager algorithmsManager)
        {
            _algorithmsManager = algorithmsManager;
        }

        public IHttpActionResult GetAvailableAlgorithms()
        {
            IEnumerable<string> availableAlgorithms = _algorithmsManager.GetAvailableAlgorithms();

            return Json(availableAlgorithms);
        }

        public IHttpActionResult ManipulateText(string algorithmName, string text)
        {
            var result = _algorithmsManager.ExecuteAlgorithm(algorithmName, text);

            return Json(result);
        }
    }
}
