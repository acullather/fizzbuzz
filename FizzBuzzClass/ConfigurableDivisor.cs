using System;
using System.Text;

namespace FizzBuzz
{
    public class ConfigurableDivisor
    {
        public int Number { get; set; }
        public string Message { get; set; }

        public string AppendMessage(string msgToAppendTo, int numberTested = -1, bool combined = false)
        {
            //if (string.IsNullOrEmpty(msgToAppendTo))
            //{
            //    return Message;
            //}

            StringBuilder sb = new StringBuilder(msgToAppendTo);

            if (numberTested >= 0)
            {
                sb.Append(numberTested + " ");
            }
            else if (combined)
            {
                sb.Append(" ");
            }
            sb.Append(Message);

            return sb.ToString();
        }
    }
}
