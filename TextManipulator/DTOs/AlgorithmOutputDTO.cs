using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TextManipulator.DTOs
{
    public class AlgorithmOutputDTO
    {
        public string AlgorithmName { get; set; }

        [Display(Name = "Result:")]
        public string Result { get; set; }
    }
}