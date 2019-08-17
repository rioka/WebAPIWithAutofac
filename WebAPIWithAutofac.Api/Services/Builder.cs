using System;
using System.Diagnostics;

namespace WebAPIWithAutofac.Api.Services
{
  public class Builder : IBuilder, IDisposable
  {
    private readonly int _value;
    public Builder(int value)
    {
      _value = value;
    }

    public string Build()
    {
      return $"Built {_value}";
    }

    public void Dispose()
    {
      Debug.WriteLine($"Disposing a {nameof(Builder)} instance, created with {_value}");
    }
  }
}