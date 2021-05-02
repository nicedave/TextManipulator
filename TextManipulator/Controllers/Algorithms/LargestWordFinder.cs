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
            string[] wordsInText = text.Split(' ');
            
            int longestWordLenght = wordsInText.Max(w => w.Length);
            
            string firstLargestWord = wordsInText.FirstOrDefault(w => w.Length == longestWordLenght);

            return new AlgorithmOutputDTO() { AlgorithmName = AlgorithmName, Result = firstLargestWord };
        }
    }
}