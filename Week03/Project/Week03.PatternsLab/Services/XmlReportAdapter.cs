namespace Week03.PatternsLab.Services;

public class XmlReportAdapter
{
    private readonly JsonReportService jsonService = new();

    public string GetXmlReport()
    {
        string json = jsonService.GetJsonReport();

        Console.WriteLine("Converting JSON to XML...");

        return $"<Report>{json}</Report>";
    }
}