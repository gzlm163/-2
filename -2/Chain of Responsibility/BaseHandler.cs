using System;

public abstract class BaseHandler {
  protected BaseHandler Next { get; set; }
  protected EventBase PrivateEvent { get; set; }

  public virtual void Handle(EventBase ev) {
    if (ev != null && PrivateEvent != null && PrivateEvent.EventType == ev.EventType) {
      Console.WriteLine("{0} successfully handled", PrivateEvent.EventType);
    } else {
      Console.WriteLine("Sending event to next Handler...");
      if (Next != null)
        Next.Handle(ev);
      else
        Console.WriteLine("Unknown event. Can't handle.");
    }
  }

  protected void SetNextHandler(BaseHandler newHandler) {
    Next = newHandler;
  }
}
