using NLog;

using EighthTask.Messages;
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

            _logger.Info(LogMessage.DISPLAY);
        }

        public override void SetModel()
        {
            ViewToDisplay.ViewModel = SequenceCreater.Create();

            _logger.Info(LogMessage.SET_MODEL);
        }

        public override void SetSequenceCreater(ISequenceBuilder sequenceCreater)
        {
            SequenceCreater = sequenceCreater;

            _logger.Info(LogMessage.SET_SEQUENCE_CREATER);
        }
    }
}
