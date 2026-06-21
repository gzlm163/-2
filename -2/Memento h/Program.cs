using System;

internal class Program {
  private static void Main(string[] args) {
    FullNameClass user = new FullNameClass("Ivan", "Ivanov", "Ivanovich");
    Caretaker caretaker = new Caretaker();

    user.Print();
    caretaker.SaveState(user);

    user = new FullNameClass("Petr", "Petrov", "Petrovich");
    user.Print();
    caretaker.SaveState(user);

    user = new FullNameClass("Sergey", "Sergeev", "Sergeevich");
    user.Print();

    caretaker.RestoreState(user);
    user.Print();

    caretaker.RestoreState(user);
    user.Print();

    Console.ReadKey();
  }
}