using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextManipulator.Controllers
{
    public interface ITextManipulatorAlgorithm
    {
        string AlgorithmName { get; }
        string ManipulateText(string text);
    }
}
