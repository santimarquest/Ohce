using System;

namespace Ohce
{
    public class Ohce
    {
        private readonly Greetings greetings;

        public Ohce(Greetings greetings)
        {
            this.greetings = greetings;
        }

        public string Start()
        {
            return greetings.Start(dateTime: DateTime.Now);
        }
    }
}
