using System;
using NLog;

namespace EighthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            LogManager.GetCurrentClassLogger().Info("Info");
            Console.WriteLine("Hello World!");
        }
    }
}
