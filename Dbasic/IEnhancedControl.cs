namespace Dbasic
{
    using System;

    public interface IEnhancedControl
    {
        void AddRunTimeEvent(string eventName, string subName);

        string propName { get; }
    }
}

