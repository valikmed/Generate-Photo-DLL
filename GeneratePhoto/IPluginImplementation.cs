using System;
using ProceedPlugin.Sdk;
namespace GeneratePhoto
{
    public class IPluginImplementation : IPlugin
    {
        public string Title => "The best plugin produce by Valentyn Medvediuk";

        public string Description => "This plugin generate photo frome user input";

        public void DoSomething()
        {
            Console.WriteLine("{Title}+{Description}");
        }
    }
}

