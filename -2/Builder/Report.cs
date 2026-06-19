using System;

public class Report {
  public string Title { get; set; }
  public string Author { get; set; }
  public int Pages { get; set; }
  public string Format { get; set; }

  public void Print() {
    Console.WriteLine($"{Title}: {Author}, {Pages} pages, {Format}");
  }
}