using System;

public class StrategyClient
{
    private IStrategy _strategy;

    public void SetStrategy(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void UseStrategy()
    {
        if (_strategy != null)
        {
            _strategy.Use();
        }
        else
        {
            Console.WriteLine("Strategy not set.");
        }
    }
}