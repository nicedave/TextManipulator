using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TextManipulator.Controllers
{
    public class LargestWordFinder : ITextManipulatorAlgorithm
    {
        public string AlgorithmName
        {
            get { return "Largest Word"; }
        }

        public string ManipulateText(string text)
        {
            string[] wordsInText = text.Split(' ');
            
            int longestWordLenght = wordsInText.Max(w => w.Length);
            
            string firstLargestWord = wordsInText.FirstOrDefault(w => w.Length == longestWordLenght);

            return firstLargestWord;
        }
    }
}