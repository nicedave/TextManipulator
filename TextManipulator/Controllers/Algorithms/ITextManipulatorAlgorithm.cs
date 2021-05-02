using TextManipulator.DTOs;

namespace TextManipulator.Controllers.Algorithms
{
    public interface ITextManipulatorAlgorithm
    {
        string AlgorithmName { get; }
        AlgorithmOutputDTO ManipulateText(string text);
    }
}
