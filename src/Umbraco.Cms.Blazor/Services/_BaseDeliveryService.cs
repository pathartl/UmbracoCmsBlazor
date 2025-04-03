using Umbraco.Cms.Blazor.Models;

namespace Umbraco.Cms.Blazor.Services;

public class BaseDeliveryService(HttpClient httpClient) : BaseService(httpClient)
{
    protected override string BaseRoute => "/umbraco/delivery/api/v2";
}