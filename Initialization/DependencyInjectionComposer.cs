using Microsoft.Extensions.DependencyInjection;
using Setupper.Umbraco.Services;
using Setupper.Umbraco.Services.Interface;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;

namespace Setupper.Umbraco.Initialization
{
    public class DependencyInjectionComposer : IComposer
    {
        public void Compose(IUmbracoBuilder builder)
        {
            builder.Services.AddTransient<IBaseControllerFacade, BaseControllerFacade>();
        }
    }
}
