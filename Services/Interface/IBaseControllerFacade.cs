using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.Extensions.Logging;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.Controllers;

namespace Setupper.Umbraco.Services.Interface
{
    /// <summary>
    /// Use a service facade to group all services needed for the base controller
    /// </summary>
    public interface IBaseControllerFacade
    {
        ILogger<RenderController> GetRenderControllerLogger();
        ICompositeViewEngine GetCompositeViewEngine();
        IUmbracoContextAccessor GetUmbracoContextAccessor();
    }
}
