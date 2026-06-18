public class ReportDirector
{
    private IReportBuilder _builder;

    public ReportDirector(IReportBuilder builder)
    {
        _builder = builder;
    }

    public void BuildSimpleReport()
    {
        _builder.SetTitle("Simple Report");
        _builder.SetAuthor("John Doe");
        _builder.SetPages(5);
        _builder.SetFormat("Text");
    }

    public void BuildFullReport()
    {
        _builder.SetTitle("Full Report");
        _builder.SetAuthor("Jane Smith");
        _builder.SetPages(20);
        _builder.SetFormat("Detailed");
    }
}