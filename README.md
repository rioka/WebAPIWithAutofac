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