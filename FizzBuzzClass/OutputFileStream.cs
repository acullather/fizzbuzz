using System;
using System.IO;
using System.Text;

namespace FizzBuzz
{
    public class OutputFileStream : FileStream, IOutput
    {
        public OutputFileStream(string fileName, FileMode fileMode) :
            base(fileName, fileMode)
        {
        }

        public void Write(string message)
        {
            byte[] byteMsg = Encoding.Unicode.GetBytes(message);
            this.Write(byteMsg, 0, byteMsg.Length);
        }
    }
}
