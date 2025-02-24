namespace Dbasic
{
    using System;
    using System.IO;

    public class CStreamRandom : FileStream, IStream
    {
        public CStreamRandom(string path, FileMode fileMode, FileAccess fileAccess) : base(path, fileMode, fileAccess)
        {
        }
    }
}

