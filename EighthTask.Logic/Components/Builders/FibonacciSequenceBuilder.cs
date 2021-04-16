using EighthTask.Logic.Components.Builders.Interfaces;
using EighthTask.Logic.Components.Interfaces;

namespace EighthTask.Logic.Components.Builders
{
    public class FibonacciSequenceBuilder : ISequenceBuilder
    {
        public int MaxRange { get; protected set; }
        public int MinRange { get; protected set; }

        public FibonacciSequenceBuilder(int maxRange, int minRange) 
        {
            MaxRange = maxRange;
            MinRange = minRange;
        }

        public ISequence Create() 
        {
            return new FibonacciSequence(MaxRange, MinRange);
        }
    }
}
