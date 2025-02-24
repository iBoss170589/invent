namespace Dbasic
{
    using System;
    using System.IO;
    using System.Text;

    public class CStreamWriter : StreamWriter, IStream
    {
        public CStreamWriter(string path, bool append, Encoding encoding) : base(path, append, encoding)
        {
        }
    }
}

