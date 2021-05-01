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
        //public TextManipulatorsController(List<ITextManipulator> _textManipulations)
        //{

        //}

        public IHttpActionResult Get()
        {
            //TODO: restituire gli algoritmi disponibili
            var s = new LargestWordFinder().AlgorithmName;

            return Json(s);
        }

        public IHttpActionResult Get(string algorithmName, string text)
        {
            //TODO: sostituire
            var s = new LargestWordFinder().ManipulateText(text);

            return Json(s);
        }
    }
}
