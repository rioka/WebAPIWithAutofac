using System.Web.Http;
using Microsoft.Owin;
using Owin;
using WebAPIWithAutofac.Api;

[assembly: OwinStartup(typeof(Startup))]
namespace WebAPIWithAutofac.Api
{
  public partial class Startup
  {
    #region Apis

    /// <summary>
    /// Owin configuration module
    /// </summary>
    /// <param name="app">Application builder</param>
    public void Configuration(IAppBuilder app)
    {
      var config = new HttpConfiguration();
      WebApiConfig.Register(config);

      app.UseWebApi(config);
    }

    #endregion
  }
}