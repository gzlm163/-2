using System;

internal class Program {
  private static void Main(string[] args) {
    IDevice tv = new TV();
    RemoteControl remote = new RemoteControl(tv);
    remote.TurnOn();
    remote.TurnOff();

    IDevice radio = new Radio();
    AdvancedRemoteControl advancedRemote = new AdvancedRemoteControl(radio);
    advancedRemote.TurnOn();
    advancedRemote.Mute();
    advancedRemote.TurnOff();

    Console.ReadKey();
  }
}