using EighthTask.Logic.UserInterface.Abstracts;
using EighthTask.Logic.Components.Interfaces;

namespace EighthTask.Models
{
    public class FibonacciViewModel : Model
    {
        public override void SetSequence(ISequence sequence)
        {
            Sequence = sequence;
        }
    }
}
