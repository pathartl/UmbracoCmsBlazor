namespace Umbraco.Cms.Blazor.Models;

public class ApiContentRoute
{
    public ApiContentRoute(string path, ApiContentStartItem startItem)
    {
        Path = path;
        StartItem = startItem;
    }

    public string Path { get; }

    public ApiContentStartItem StartItem { get; }
}
