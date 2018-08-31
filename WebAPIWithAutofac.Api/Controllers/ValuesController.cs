using System.Collections.Generic;
using System.Web.Http;

namespace WebAPIWithAutofac.Api.Controllers
{
  public class ValuesController : ApiController
  {
    #region Data

    #endregion

    #region Constructors

    public ValuesController()
    {}

    #endregion

    #region Apis

    public IEnumerable<string> Get()
    {
      return new[] {
        1.ToString(),
        2.ToString()
      };
    }

    #endregion
  }
}