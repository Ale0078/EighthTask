using System.Collections.Generic;

using EighthTask.Logic.Components.Interfaces;

namespace EighthTask.Logic.Components
{
    internal class FibonacciSequence : ISequence
    {
        private readonly int _maxRange;
        private readonly int _minRange;

        public FibonacciSequence(int maxRange, int minRange) 
        {
            _maxRange = maxRange;
            _minRange = minRange;
        }

        public IEnumerator<int> GetEnumerator() 
        {
            int[] fibonacciNumbers = { 0, 1 };

            for (int i = 0; (fibonacciNumbers[0] + fibonacciNumbers[1]) < _maxRange; i++)
            {
                fibonacciNumbers[i % 2] = fibonacciNumbers[0] + fibonacciNumbers[1];

                if (fibonacciNumbers[i % 2] > _minRange)
                {
                    yield return fibonacciNumbers[i % 2];
                }
            }
        }
    }
}
