using System;

public class ChainApplication {
  private readonly BaseHandler _eventHandler;
  private readonly Random _randomGenerator;

  public ChainApplication() {
    _eventHandler = new Handler1();
    _randomGenerator = new Random();
  }

  public void Run(int eventCount) {
    for (int currentIndex = 0; currentIndex < eventCount; ++currentIndex) {
      HandleEvent(GenerateRandomEvent());
    }
  }

  private void HandleEvent(EventBase eventData) {
    _eventHandler.Handle(eventData);
  }

  private EventBase GenerateRandomEvent() {
    int randomValue = _randomGenerator.Next(1, 6);
    EventBase result;

    switch (randomValue) {
      case 1:
        result = new Event1();
        break;
      case 2:
        result = new Event2();
        break;
      case 3:
        result = new Event3();
        break;
      case 4:
        result = new Event4();
        break;
      case 5:
        result = new Event5();
        break;
      default:
        result = new Event1();
        break;
    }

    Console.WriteLine($"Generated event: {result.EventType}");
    return result;
  }
}