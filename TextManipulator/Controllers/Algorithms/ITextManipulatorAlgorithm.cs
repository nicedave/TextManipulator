using TextManipulator.DTOs;

namespace TextManipulator.Controllers
{
    public interface ITextManipulatorAlgorithm
    {
        string AlgorithmName { get; }
        AlgorithmOutputDTO ManipulateText(string text);
    }
}
