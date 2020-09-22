namespace LSPLibrary
{
    public class InformationEvent: IEvent
    {
        public string EventName {get; set;}
        public void Notify()
        {
            new TextAlert().Send(this);
        }
    }
}