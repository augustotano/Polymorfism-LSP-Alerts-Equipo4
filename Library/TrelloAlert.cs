using System;
namespace LSPLibrary
{
    public class TrelloAlert: IAlert
    {
        public void Send (IEvent e)
        {
            new TrelloCardCreator().CreateCard(e.EventName);
        }
    }
}