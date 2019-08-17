using Autofac;
using WebAPIWithAutofac.Api.Services;

namespace WebAPIWithAutofac.Api.Infrastructure.IoC
{
  public class ComponentsInstaller : Autofac.Module
  {
    protected override void Load(ContainerBuilder builder)
    {
      builder.RegisterType<ValueProvider>()
        .AsImplementedInterfaces()
        .InstancePerRequest();

      builder.RegisterType<Builder>()
        .AsImplementedInterfaces()
        .InstancePerDependency();
    }
  }
}