using Microsoft.Extensions.Configuration;
using Umbraco.Cms.Blazor.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Umbraco.Cms.Blazor.Services;

namespace Umbraco.Cms.Blazor.Extensions;

public static class IHostApplicationBuilderExtensions
{
    public static IHostApplicationBuilder AddUmbracoClient(this IHostApplicationBuilder builder)
    {
        var settings = builder.Configuration.Get(typeof(UmbracoSettings)) as UmbracoSettings;
        
        builder.Services.AddScoped<UmbracoClient>();
        builder.Services.AddSingleton(settings);
        builder.Services.AddSingleton<ComponentService>();

        return builder;
    }
}