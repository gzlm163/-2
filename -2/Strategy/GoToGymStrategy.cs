using System;

public class GoToGymStrategy : IStrategy
{
    public void Use()
    {
        GoOut();
        Arrive();
        DoExercises();
    }

    private void GoOut() { Console.WriteLine("Go out."); }
    private void Arrive() { Console.WriteLine("Arrive."); }
    private void DoExercises() { Console.WriteLine("Do exercises."); }
}