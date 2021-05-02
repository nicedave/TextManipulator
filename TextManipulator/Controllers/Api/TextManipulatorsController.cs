using System.Collections.Generic;
using System.Web.Http;
using TextManipulator.Controllers.Algorithms;

namespace TextManipulator.Controllers.Api
{
    public class TextManipulatorsController : ApiController
    {
        private readonly IAlgorithmsManager _algorithmsManager;
        public TextManipulatorsController(IAlgorithmsManager algorithmsManager)
        {
            _algorithmsManager = algorithmsManager;
        }

        [HttpGet]
        public IHttpActionResult GetAvailableAlgorithms()
        {
            IEnumerable<string> availableAlgorithms = _algorithmsManager.GetAvailableAlgorithms();

            return Json(availableAlgorithms);
        }

        [HttpGet]
        public IHttpActionResult ExecuteAllAlgorithms(string text)
        {
            var result = _algorithmsManager.ExecuteAllAlgorithms(text);

            return Json(result);
        }

        [HttpGet]
        public IHttpActionResult ExecuteAlgorithm(string algorithmName, string text)
        {
            var result = _algorithmsManager.ExecuteAlgorithm(algorithmName, text);

            return Json(result);
        }
    }
}
