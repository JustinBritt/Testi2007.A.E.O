namespace Testi2007.A.E.O.InterfacesFactories.Results.Common.OverallWallTime
{
    using System;

    using Testi2007.A.E.O.Interfaces.Results.Common.OverallWallTime;

    public interface IOverallWallTimeFactory
    {
        IOverallWallTime Create(
            TimeSpan value);
    }
}