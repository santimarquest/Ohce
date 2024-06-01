using FluentAssertions;
using NSubstitute;
using NUnit.Framework.Internal;

namespace Ohce.Tests1
{
    public class OhceTests
    {
        private Greetings greetings;
        private StringTool stringTool;
        private string name => "Antonio";

        [SetUp]
        public void Setup()
        {
            greetings = Substitute.For<Greetings>();
            greetings.Start(Arg.Any<DateTime>()).Returns(@$"Buenos días, {name}");
            stringTool = Substitute.For<StringTool>();
        }
        [Test]
        public void start_in_the_morning_should_say_buenos_días_to_user()
        {
            var result = new Ohce(greetings).Start();
            result.Should().Be("Buenos días, Antonio");
        }
    }
}
