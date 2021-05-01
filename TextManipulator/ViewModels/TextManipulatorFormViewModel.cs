using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TextManipulator.DTOs;

namespace TextManipulator.ViewModels
{
    public class TextManipulatorFormViewModel
    {
        [Required (ErrorMessage = "Please enter some text.")]
        [Display (Name = "Type your text:")]
        public string Text { get; set; }

        public IEnumerable<string> AvailableAlgorithms { get; set; }

        [Required(ErrorMessage = "Please select an Algorithm.")]
        [Display(Name = "Select an Algorithm:")]
        public string SelectedAlgorithm { get; set; }

        public AlgorithmOutputDTO AlgorithmOutput { get; set; }
    }
}