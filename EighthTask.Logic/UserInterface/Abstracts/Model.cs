using EighthTask.Logic.Components.Interfaces;

namespace EighthTask.Logic.UserInterface.Abstracts
{
    public abstract class Model
    {
        public ISequence Sequence { get; set; }

        public abstract void SetSequence(ISequence sequence);
    }
}
