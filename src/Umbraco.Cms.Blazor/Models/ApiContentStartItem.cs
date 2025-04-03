namespace Umbraco.Cms.Blazor.Models;

public class ApiContentStartItem
{
    public ApiContentStartItem(Guid id, string path)
    {
        Id = id;
        Path = path;
    }

    public Guid Id { get; }

    public string Path { get; }
}
