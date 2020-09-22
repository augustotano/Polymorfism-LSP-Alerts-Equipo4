using System;

namespace LSPLibrary
{
    public interface IEvent
    {
        string EventName {get; set;}
        void Notify();
    }
}