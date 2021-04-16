using NLog;

using EighthTask.Logic.UserInterface.Abstracts;
using EighthTask.Logic.Components.Builders.Interfaces;

namespace EighthTask.Controllers
{
    public class FibonacciController : Controller
    {
        private readonly ILogger _logger;

        public FibonacciController(View viewToDisplay, ISequenceBuilder sequenceCreater) :
            base(viewToDisplay, sequenceCreater)
        {
            _logger = LogManager.GetCurrentClassLogger();
        }

        public override void Display()
        {
            ViewToDisplay.Display();

            _logger.Info("Sequence was outputted (FibonacciController.Display)");
        }

        public override void SetModel()
        {
            ViewToDisplay.ViewModel.SetSequence(SequenceCreater.Create());

            _logger.Info("Model was setted (FibonacciController.SetModel)");
        }

        public override void SetSequenceCreater(ISequenceBuilder sequenceCreater)
        {
            SequenceCreater = sequenceCreater;

            _logger.Info("New SequenceCreater was setted (FibonacciController.SetSequenceCreater)");
        }
    }
}
