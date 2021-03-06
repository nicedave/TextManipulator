using System.Collections.Generic;
using System.Linq;
using TextManipulator.DTOs;

namespace TextManipulator.Controllers.Algorithms
{
    public class AlgorithmsManager : IAlgorithmsManager
    {
        private readonly IEnumerable<ITextManipulatorAlgorithm> _textManipulators;
        public AlgorithmsManager(IEnumerable<ITextManipulatorAlgorithm> textManipulators)
        {
            _textManipulators = textManipulators;
        }

        public IEnumerable<string> GetAvailableAlgorithms()
        {
            return _textManipulators.Select(m => m.AlgorithmName);
        }

        public AlgorithmOutputDTO ExecuteAlgorithm(string algorithmName, string text)
        {
            ITextManipulatorAlgorithm algorithm = _textManipulators.SingleOrDefault(m => m.AlgorithmName == algorithmName);
            return algorithm.ManipulateText(text);
        }

        public IEnumerable<AlgorithmOutputDTO> ExecuteAllAlgorithms(string text)
        {
            return (from t in _textManipulators select t.ManipulateText(text));
        }
    }
}