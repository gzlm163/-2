public interface IReportBuilder {
  void SetTitle(string title);
  void SetAuthor(string author);
  void SetPages(int pages);
  void SetFormat(string format);
  Report GetReport();
}