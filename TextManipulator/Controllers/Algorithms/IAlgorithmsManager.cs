using System.Collections.Generic;
using TextManipulator.DTOs;

namespace TextManipulator.Controllers
{
    public interface IAlgorithmsManager
    {
        AlgorithmOutputDTO ExecuteAlgorithm(string algorithmName, string text);
        IEnumerable<string> GetAvailableAlgorithms();
    }
}