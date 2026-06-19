using System;

public class Radio : IDevice {
  public void TurnOn() {
    Console.WriteLine("Radio is ON");
  }

  public void TurnOff() {
    Console.WriteLine("Radio is OFF");
  }
}