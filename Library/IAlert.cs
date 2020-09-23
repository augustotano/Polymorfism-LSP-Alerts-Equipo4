using System;

namespace LSPLibrary
{
    public interface IAlert
    {
        void Send(IEvent e);
    }
}