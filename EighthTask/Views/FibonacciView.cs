using static System.Console;

using EighthTask.Logic.UserInterface.Abstracts;

namespace EighthTask.Views
{
    public class FibonacciView : View
    {
        public FibonacciView(Model viewModel) : base(viewModel) 
        {
        }

        public override void Display()
        {
            foreach (var number in ViewModel.Sequence)
            {
                Write("{0}, ", number);
            }

            WriteLine();
        }
    }
}
