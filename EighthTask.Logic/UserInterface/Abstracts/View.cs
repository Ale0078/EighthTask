namespace EighthTask.Logic.UserInterface.Abstracts
{
    public abstract class View
    {
        public Model ViewModel { get; }

        public View(Model viewModel) 
        {
            ViewModel = viewModel;
        }

        public abstract void Display();
    }
}
