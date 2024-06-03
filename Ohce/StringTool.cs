using System.Linq;

namespace Ohce
{
    public class StringTool
    {
        public string Reverse(string word)
        {
            return new string(word.Reverse().ToArray());
        }

        public bool Palindrome(string word)
        {
            return (word == Reverse(word));
        }
    }
}