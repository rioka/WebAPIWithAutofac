# WebAPIWithAutofac
Sample Web API project from scratch using Autofac

* Create a new Web project, using "ASP.Net Web Application" project type, and the "Empty" template

## Add references
* Install required packages  
  ```
  install-package Microsoft.AspNet.WebApi.Core
  install-package Microsoft.Owin.Host.SystemWeb
  install-package Microsoft.Owin.Security.OAuth
  install-package Microsoft.AspNet.WebApi.Owin
  ```

## Add files and folders
* Add the following folders
  * `App_Start`  
  * `Controllers`
* Add the following files
  * `.\Startup.cs`
  * `.\App_Start\Startup.Auth.cs`
  * `.\App_Start\WebApiConfig.cs`

## Add code
* Create a `Controllers` folder
* Create file `.\Controllers\ValuesController.cs`
* Add code to
  * `.\App_Start\WebApiConfig.cs`
  * `Startup.cs`

Now you have a working OWIN Web API application

## Add a dependency 
* Add a `Services` folder
* Add `.\Services\IValueProvider.cs`
* Add `.\Services\ValueProvider.cs`
* Add `IValueProvider` as a constructor dependency to `ValuesController`

**Site will stop working**

## Add Autofac
* `Install-Package Autofac.WebApi2`
* `Install-Package Autofac.WebApi2.Owin`

## Setup Autofac
* Add Autofac setup code
  * Register controllers
  * Register components
  * Build a container and set it as `DependencyResolver` for the current `HttpConfigutation`
  * Call `UseAutofacMiddleware`
  * Call `UseAutofacWebApi`
