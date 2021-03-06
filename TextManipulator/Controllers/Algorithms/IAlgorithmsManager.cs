using System.Collections.Generic;
using TextManipulator.DTOs;

namespace TextManipulator.Controllers.Algorithms
{
    public interface IAlgorithmsManager
    {
        IEnumerable<AlgorithmOutputDTO> ExecuteAllAlgorithms(string text);
        AlgorithmOutputDTO ExecuteAlgorithm(string algorithmName, string text);
        IEnumerable<string> GetAvailableAlgorithms();
    }
}