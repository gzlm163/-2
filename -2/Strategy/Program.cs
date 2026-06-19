using System;

internal class Program {
  private static void Main(string[] args) {
    StrategyClient client = new StrategyClient();

    client.SetStrategy(new GoToWorkStrategy());
    client.UseStrategy();
    Console.WriteLine();

    client.SetStrategy(new GoToGymStrategy());
    client.UseStrategy();
    Console.WriteLine();

    client.SetStrategy(new GoWalkStrategy());
    client.UseStrategy();

    Console.ReadKey();
  }
}