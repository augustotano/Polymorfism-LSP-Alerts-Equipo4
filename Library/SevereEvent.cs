namespace LSPLibrary
{
    public class SevereEvent: IEvent
    {
        public string EventName {get; set;}
        public void Notify()
        {
            IAlert[] alerts = new IAlert[]
            {
                new TrelloAlert(),
                new TextAlert()
            };

            foreach (IAlert alert in alerts)
            {
                alert.Send(this);
            }
        }
    }
}