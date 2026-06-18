public class PdfReportBuilder : IReportBuilder
{
    private Report _report = new Report();

    public void SetTitle(string title)
    {
        _report.Title = title;
    }

    public void SetAuthor(string author)
    {
        _report.Author = author;
    }

    public void SetPages(int pages)
    {
        _report.Pages = pages;
    }

    public void SetFormat(string format)
    {
        _report.Format = format;
    }

    public Report GetReport()
    {
        return _report;
    }
}
