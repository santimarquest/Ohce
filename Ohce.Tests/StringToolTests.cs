using FluentAssertions;

namespace Ohce.Tests
{
    public class StringToolTests
    {
        [Test]
        public void abc_reverse_should_return_cba()
        {
            var word = "abc";
            var result = new StringTool().Reverse(word);
            result.Should().Be("cba");
        }

        [Test]
        public void aba_palindrome_should_return_true()
        {
            var word = "aba";
            var result = new StringTool().Palindrome(word);
            result.Should().Be(true);
        }

        [Test]
        public void xyz_palindrome_should_return_false()
        {
            var word = "xyz";
            var result = new StringTool().Palindrome(word);
            result.Should().Be(false);

        }
    }
}
