using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TextManipulator.Controllers.Api
{
    public class TextManipulatorsController : ApiController
    {
        IEnumerable<ITextManipulatorAlgorithm> _textManipulators;
        public TextManipulatorsController(IEnumerable<ITextManipulatorAlgorithm> textManipulators)
        {
            _textManipulators = textManipulators;
        }

        public IHttpActionResult Get()
        {
            var s = _textManipulators.Select(m => m.AlgorithmName).ToList();

            return Json(s);
        }

        public IHttpActionResult Get(string algorithmName, string text)
        {
            //TODO: creare metodo post
            var s = new LargestWordFinder().ManipulateText(text);

            return Json(s);
        }
    }
}
