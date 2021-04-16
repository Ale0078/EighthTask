using static System.Console;

using EighthTask.Logic.UserInterface.Abstracts;

namespace EighthTask.Views
{
    public class FibonacciView : View
    {
        public override void Display()
        {
            foreach (var number in ViewModel)
            {
                Write("{0}, ", number);
            }

            WriteLine();
        }
    }
}
