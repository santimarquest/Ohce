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
            greetings.Start(Arg.Any<string>(), Arg.Any<DateTime>()).Returns(@$"Buenos días, {name}");
            greetings.Stop(Arg.Any<string>()).Returns(@$"Adiós, {name}");
            stringTool = Substitute.For<StringTool>();
        }
        [Test]
        public void start_in_the_morning_should_say_buenos_días_to_user()
        {
            var result = new Ohce(greetings, stringTool).Start(name);
            result.Should().Be("Buenos días, Antonio");
        }

        [Test]
        public void stop_should_say_adios_to_user()
        {
            var result = new Ohce(greetings, stringTool).Stop(name);
            result.Should().Be("Adiós, Antonio");
        }

        [Test]
        public void process_hola_should_return_aloh()
        {
            var word = "hola";
            var result = new Ohce(greetings, stringTool).ProcessWord(word);
            result.Should().Be("aloh");
        }

        [Test]
        public void bonita_palabra_oto_should_return_bonita_palabra()
        {
            var word = "oto";
            var result = new Ohce(greetings, stringTool).BonitaPalabra(word);
            result.Should().Be("Bonita Palabra!");
        }
    }
}
