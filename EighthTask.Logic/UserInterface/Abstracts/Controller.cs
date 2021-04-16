using EighthTask.Logic.Components.Builders.Interfaces;

namespace EighthTask.Logic.UserInterface.Abstracts
{
    public abstract class Controller
    {
        public View ViewToDisplay { get; protected set; }
        public ISequenceBuilder SequenceCreater { get; protected set; }

        public Controller(View viewToDisplay, ISequenceBuilder sequenceCreater) 
        {
            ViewToDisplay = viewToDisplay;
            SequenceCreater = sequenceCreater;
        }

        public abstract void Display();
        public abstract void SetModel(int maxSequenceRange, int minSequenceRange);
        public abstract void SetSequenceCreater(ISequenceBuilder sequenceCreater);
    }
}
