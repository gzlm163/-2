using System;

public class GoWalkStrategy : IStrategy
{
    public void Use()
    {
        GoOut();
        Walk();
    }

    private void GoOut() { Console.WriteLine("Go out."); }
    private void Walk() { Console.WriteLine("Walk."); }
}