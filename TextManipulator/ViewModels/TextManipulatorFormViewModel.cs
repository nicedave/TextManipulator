using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TextManipulator.ViewModels
{
    public class TextManipulatorFormViewModel
    {
        [Required]
        [Display (Name = "Type your text:")]
        public string Text { get; set; }

        public List<string> AvailableAlgorithms { get; set; }

        [Required]
        [Display(Name = "Select an Algorithm:")]
        public string SelectedAlgorithm { get; set; }

        [Display(Name = "Result:")]
        public string ManipulatedText { get; set; }
    }
}