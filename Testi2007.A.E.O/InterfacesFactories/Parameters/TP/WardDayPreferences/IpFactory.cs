namespace Testi2007.A.E.O.InterfacesFactories.Parameters.TP.WardDayPreferences
{
    using System.Collections.Immutable;

    using Testi2007.A.E.O.Interfaces.ParameterElements.TP.WardDayPreferences;
    using Testi2007.A.E.O.Interfaces.Parameters.TP.WardDayPreferences;

    public interface IpFactory
    {
        Ip Create(
            ImmutableList<IpParameterElement> value);
    }
}