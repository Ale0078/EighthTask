using EighthTask.Logic.Components.Interfaces;

namespace EighthTask.Logic.UserInterface.Abstracts
{
    public abstract class View
    {
        public ISequence ViewModel { get; set; }

        public abstract void Display();
    }
}
