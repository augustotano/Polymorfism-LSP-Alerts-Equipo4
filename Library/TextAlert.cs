using System;
namespace LSPLibrary
{
    public class TextAlert: IAlert
    {
        public void Send (IEvent e)
        {
            Console.WriteLine(e.EventName);
        }
    }
}