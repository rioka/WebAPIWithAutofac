using System;
using System.Collections.Generic;
using System.Web.Http;
using WebAPIWithAutofac.Api.Services;

namespace WebAPIWithAutofac.Api.Controllers
{
  public class ValuesController : ApiController
  {
    #region Data

    private readonly IValueProvider _valueProvider;
    private readonly Func<int, IBuilder> _builderFactory;

    #endregion

    #region Constructors

    public ValuesController(IValueProvider valueProvider, Func<int, IBuilder> builderFactory)
    {
      _valueProvider = valueProvider;
      _builderFactory = builderFactory;
    }

    #endregion

    #region Apis

    public IEnumerable<string> Get()
    {
      var builder1 = _builderFactory(1);
      var builder2 = _builderFactory(2);

      return new[] {
        _valueProvider.Get(),
        _valueProvider.Get(),
        builder1.Build(),
        builder2.Build(),
      };
    }

    #endregion
  }
}