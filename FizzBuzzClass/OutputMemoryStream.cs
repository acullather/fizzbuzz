using System;
using System.IO;
using System.Text;

namespace FizzBuzz
{
    public class OutputMemoryStream : MemoryStream, IOutput
    {
        public OutputMemoryStream() 
            : base()
        {}

        public void Write(string message)
        {
            byte[] byteMsg = Encoding.Unicode.GetBytes(message);
            this.Write(byteMsg, 0, byteMsg.Length);
        }
    }
}
