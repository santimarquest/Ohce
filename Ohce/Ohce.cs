using System;

namespace Ohce
{
    public class Ohce
    {
        private readonly Greetings greetings;
        private readonly StringTool stringTool;

        public Ohce(Greetings greetings, StringTool stringTool)
        {
            this.greetings = greetings;
            this.stringTool = stringTool;
        }

        public string Start(string name)
        {
            return greetings.Start(name, dateTime: DateTime.Now);
        }

        public string Stop(string name)
        {
            return greetings.Stop(name);
        }

        public string ProcessWord(string word)
        {
            return stringTool.Reverse(word);
        }

        public string BonitaPalabra(string word)
        {
            if (stringTool.Palindrome(word))
            {
                return "Bonita Palabra!";
            }

            return string.Empty;
        }
    }
}
