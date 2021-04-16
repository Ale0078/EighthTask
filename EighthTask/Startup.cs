using System;
using NLog;

using static System.Console;

using EighthTask.Controllers;
using EighthTask.Views;
using EighthTask.Logic.Components.Builders;
using EighthTask.Logic.UserInterface.Abstracts;
using LibToTasks.Validation.Interfaces;
using LibToTasks.Builders;

namespace EighthTask
{
    public class Startup
    {
        private const int MAX_RANGE = 1000000;

        private readonly ILogger _logger;
        private readonly IValidator _validator;
        private readonly ITransformator _transformator;

        public Startup() 
        {
            _logger = LogManager.GetCurrentClassLogger();

            _validator = new DefaultValidatorBuilder().Create();
            _transformator = new DefaultTransformatorBuilder().Create();
        }

        public void Start(string[] mainArgument) 
        {
            if (mainArgument.Length != 2) 
            {
                GetMessage();

                return;
            }

            if (!uint.TryParse(mainArgument[0], out _) || !uint.TryParse(mainArgument[1], out _)) 
            {
                GetMessage();

                return;
            }

            int[] range = GetRange(mainArgument);

            if (!CheckRange(range)) 
            {
                GetMessage();

                return;
            }

            Controller fibonacciController = new FibonacciController(new FibonacciView(),
                sequenceCreater: new FibonacciSequenceBuilder(range[0], range[1]));

            fibonacciController.SetModel();
            fibonacciController.Display();

            _logger.Info("Program is finalized");
        }

        private int[] GetRange(string[] mainArgument) 
        {
            int[] range = new int[2];

            for (int i = 0; i < range.Length; i++)
            {
                range[i] = _transformator.ConfirmConversion<int, string>(mainArgument[i]);
            }

            return range;
        }

        private bool CheckRange(int[] range) 
        {
            bool flage = true;

            for (int i = 0; i < range.Length; i++)
            {
                if (!_validator.CheckValue(valueToCheck =>
                 {
                     if (valueToCheck > MAX_RANGE)
                     {
                         return false;
                     }

                     return true;
                 }, range[i], false)) 
                {
                    flage = false;

                    break;
                }
            }

            if (range[0] < range[1]) 
            {
                flage = false;
            }

            return flage;
        }

        private void GetMessage() 
        {
            WriteLine("You must enter two number from 0 to 1000000 and these numbers must be like int.\n " +
                "First number is max range but second number is min range");

            _logger.Info("You must enter two number from 0 to 1000000 and these numbers must be like int.\n" +
                "First number is max range but second number is min range");

            _logger.Info("Program is finalized");
        }
    }
}
