using System;

internal class Program
{
    private static void Main(string[] args)
    {
        IReportBuilder builder = new PdfReportBuilder();
        ReportDirector director = new ReportDirector(builder);

        director.BuildSimpleReport();
        Report simpleReport = builder.GetReport();
        simpleReport.Print();

        builder = new HtmlReportBuilder();
        director = new ReportDirector(builder);

        director.BuildFullReport();
        Report fullReport = builder.GetReport();
        fullReport.Print();

        Console.ReadKey();
    }
}