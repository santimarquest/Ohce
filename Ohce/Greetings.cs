using System;

namespace Ohce
{
    public class Greetings
    {
        private StringTool stringTool { get; set; }

        public Greetings()
        {

        }
        public Greetings(StringTool stringTool)
        {
            this.stringTool = stringTool;
        }
        public virtual string Start(DateTime dateTime)
        {
            return String.Empty;
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

    }


}
