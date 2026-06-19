using System;

public class AdvancedRemoteControl : RemoteControl {
  public AdvancedRemoteControl(IDevice device) : base(device) {
  }

  public void Mute() {
    Console.WriteLine("Device muted");
  }
}