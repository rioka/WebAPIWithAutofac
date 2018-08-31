using System;

namespace WebAPIWithAutofac.Api.Services
{
  public class ValueProvider : IValueProvider
  {
    private static readonly Random Rgn = new Random();

    #region IValueProvider

    public string Get()
    {
      return Rgn.Next().ToString();
    }

    #endregion
  }
}