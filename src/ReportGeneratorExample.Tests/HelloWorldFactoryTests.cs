using System;
using Xunit;

namespace ReportGeneratorExample.Tests
{
    public class HelloWorldFactoryTests
    {
        private readonly HelloWorldFactory _helloWorldFactory = new HelloWorldFactory();

        [Fact]
        public void MakesGrumpyGreeting()
        {
            var expected = "Hello world.";
            var actual = _helloWorldFactory.GetMessage(false);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MakesHappyGreeting()
        {
            var expected = "Hello beautiful world!";
            var actual = _helloWorldFactory.GetMessage(true);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsGrumpyByDefault()
        {
            var expected = "Hello world.";
            var actual = _helloWorldFactory.GetMessage(); // Without argument
            Assert.Equal(expected, actual);
        }
    }
}
