using System;

public class ChainApplication {
  public ChainApplication() {
    eventHandler = new Handler1();
    Rand = new Random();
  }

  public void Run(int EventCount) {
    for (int i = 0; i < EventCount; i++) {
      HandleEvent(GenerateRandomEvent());
    }
  }

  private void HandleEvent(EventBase ev) {
    eventHandler.Handle(ev);
  }

  private EventBase GenerateRandomEvent() {
    EventBase result;
    switch (Rand.Next(1, 6)) {
      case 1: result = new Event1(); break;
      case 2: result = new Event2(); break;
      case 3: result = new Event3(); break;
      case 4: result = new Event4(); break;
      case 5: result = new Event5(); break;
      default: result = new Event1(); break;
    }
    Console.WriteLine("Generated event: {0}", result.EventType);
    return result;
  }

  private BaseHandler eventHandler;
  private Random Rand;
}