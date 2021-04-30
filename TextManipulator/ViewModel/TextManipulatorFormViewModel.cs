using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TextManipulator.ViewModel
{
    public class TextManipulatorFormViewModel
    {
        [Required]
        [Display (Name = "Type your text:")]
        public string Text { get; set; }

        public string ManipulatedText { get; set; }

        public string AlgorithmName { get; set; }

        //public IEnumerable<string> Algorithms { get; set; }
        //[Required]
        //public string SelectedAlgorithm { get; set; }
    }
}