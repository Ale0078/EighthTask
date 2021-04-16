using System.Collections.Generic;

namespace EighthTask.Logic.Components.Interfaces
{
    public interface ISequence
    {
        IEnumerator<int> GetEnumerator();
    }
}
