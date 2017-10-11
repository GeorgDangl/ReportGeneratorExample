using System;

namespace ReportGeneratorExample
{
    public class HelloWorldFactory
    {
        public string GetMessage(bool isInGoodMood = false)
        {
            if (isInGoodMood)
            {
                return "Hello beautiful world!";
            }
            return "Hello world.";
        }
    }
}
