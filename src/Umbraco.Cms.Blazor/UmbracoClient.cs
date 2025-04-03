using Umbraco.Cms.Blazor.Services;

namespace Umbraco.Cms.Blazor;

public class UmbracoClient(HttpClient httpClient)
{
    public ContentService Content = new ContentService(httpClient);
    public MediaService Media = new MediaService(httpClient);
}