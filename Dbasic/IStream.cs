namespace Dbasic
{
    using System;

    public interface IStream
    {
        void Close();
        void Flush();
    }
}

