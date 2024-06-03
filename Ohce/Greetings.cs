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
        public virtual string Start(string name, DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        public virtual string Stop(string name)
        {
            throw new NotImplementedException();
        }

    }


}
