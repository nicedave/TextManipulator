﻿using System;
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

        public List<string> AvailableAlgorithms { get; set; }

        [Required]
        [Display(Name = "Selected Algorithm:")]
        public string SelectedAlgorithm { get; set; }

        [Display(Name = "Result:")]
        public string ManipulatedText { get; set; }
    }
}