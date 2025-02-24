namespace Dbasic
{
    using System;
    using System.IO;
    using System.Text;

    public class CStreamReader : StreamReader, IStream
    {
        public CStreamReader(string path, Encoding encoding) : base(path, encoding)
        {
        }

        public void Flush()
        {
            throw new Exception("Readonly stream cannot be flushed.");
        }
    }
}

