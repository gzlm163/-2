public class Caretaker
{
    private Memento _memento;

    public void SaveState(FullNameClass originator)
    {
        _memento = originator.GetMemento();
    }

    public void RestoreState(FullNameClass originator)
    {
        if (_memento != null)
        {
            originator.SetMemento(_memento);
        }
    }
}