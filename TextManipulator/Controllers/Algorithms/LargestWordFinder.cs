using System;
using System.Linq;
using TextManipulator.DTOs;

namespace TextManipulator.Controllers.Algorithms
{
    public class LargestWordFinder : ITextManipulatorAlgorithm
    {
        public string AlgorithmName
        {
            get { return "Largest Word"; }
        }

        public AlgorithmOutputDTO ManipulateText(string text)
        {
            string[] wordsInText = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string firstLargestWord = wordsInText.OrderByDescending(w => w.Length).FirstOrDefault();

            return new AlgorithmOutputDTO() { AlgorithmName = AlgorithmName, Result = firstLargestWord };
        }
    }
}