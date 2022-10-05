using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.Extensions.Logging;
using Setupper.Umbraco.Services.Interface;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.Controllers;

namespace Setupper.Umbraco.Services
{
    /// <inheritdoc cref="IBaseControllerFacade"/>
    public class BaseControllerFacade : IBaseControllerFacade
    {
        private readonly ILogger<RenderController> _renderControllerLogger;
        private readonly ICompositeViewEngine _compositeViewEngine;
        private readonly IUmbracoContextAccessor _umbracoContextAccessor;

        public BaseControllerFacade(
            ILogger<RenderController> renderControllerLogger,
            ICompositeViewEngine compositeViewEngine,
            IUmbracoContextAccessor umbracoContextAccessor)
        {
            _renderControllerLogger = renderControllerLogger;
            _compositeViewEngine = compositeViewEngine;
            _umbracoContextAccessor = umbracoContextAccessor;
        }

        public ILogger<RenderController> GetRenderControllerLogger() => _renderControllerLogger;
        public ICompositeViewEngine GetCompositeViewEngine() => _compositeViewEngine;
        public IUmbracoContextAccessor GetUmbracoContextAccessor() => _umbracoContextAccessor;
    }
}
