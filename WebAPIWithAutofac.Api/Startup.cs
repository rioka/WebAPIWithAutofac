using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using Microsoft.Owin;
using Owin;
using WebAPIWithAutofac.Api;
using WebAPIWithAutofac.Api.Services;

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

      // Autofac setup
      var builder = new ContainerBuilder();

      builder
        .RegisterApiControllers(Assembly.GetExecutingAssembly())
        .ExternallyOwned();     // just to avoid having Dispose called twice for controllers

      builder.RegisterType<ValueProvider>()
        .AsImplementedInterfaces()
        .InstancePerRequest();

      var container = builder.Build();
      config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

      // OWIN WEB API SETUP, IN THIS ORDER
      // http://autofac.readthedocs.io/en/latest/integration/webapi.html#owin-integration
      app.UseAutofacMiddleware(container);
      app.UseAutofacWebApi(config);
      // Autofac setup end

      app.UseWebApi(config);
    }

    #endregion
  }
}