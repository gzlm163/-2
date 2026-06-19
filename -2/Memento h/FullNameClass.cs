using System;

public class FullNameClass {
  public string Name { get; set; }
  public string Surname { get; set; }
  public string MiddleName { get; set; }

  public FullNameClass(string name, string surname, string middle) {
    Name = name;
    Surname = surname;
    MiddleName = middle;
  }

  public void Print() {
    Console.WriteLine($"Name={Name} Surname={Surname} Middle={MiddleName}");
  }

  public Memento GetMemento() {
    return new Memento {
      Name = this.Name,
      Surname = this.Surname,
      MiddleName = this.MiddleName
    };
  }

  public void SetMemento(Memento memento) {
    Name = memento.Name;
    Surname = memento.Surname;
    MiddleName = memento.MiddleName;
  }
}