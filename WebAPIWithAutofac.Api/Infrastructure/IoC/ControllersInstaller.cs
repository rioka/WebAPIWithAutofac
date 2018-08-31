using System.Reflection;
using Autofac;
using Autofac.Integration.WebApi;

namespace WebAPIWithAutofac.Api.Infrastructure.IoC
{
  public class ControllersInstaller : Autofac.Module
  {
    protected override void Load(ContainerBuilder builder)
    {
      builder
       .RegisterApiControllers(Assembly.GetExecutingAssembly())
       .ExternallyOwned();     // just to avoid having Dispose called twice for controllers
    }
  }
}