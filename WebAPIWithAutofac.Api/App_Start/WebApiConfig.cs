using System.Web.Http;
using Newtonsoft.Json.Serialization;

namespace WebAPIWithAutofac.Api
{
  public class WebApiConfig
  {
    #region Apis

    /// <summary>
    /// Register the configuration
    /// </summary>
    /// <param name="config"></param>
    public static void Register(HttpConfiguration config)
    {
      // Web API routes
      config.MapHttpAttributeRoutes();

      // set camelCase Json serialization
      var settings = config.Formatters.JsonFormatter.SerializerSettings;
      settings.ContractResolver = new CamelCasePropertyNamesContractResolver();

      config.Routes.MapHttpRoute(
        name: "DefaultApi",
        routeTemplate: "api/{controller}/{id}",
        defaults: new { id = RouteParameter.Optional }
      );
    }

    #endregion
  }
}