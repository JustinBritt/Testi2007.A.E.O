namespace Testi2007.A.E.O.InterfacesFactories.Parameters.TP.WardNumberOperatingTeams
{
    using System.Collections.Immutable;

    using Testi2007.A.E.O.Interfaces.ParameterElements.TP.WardNumberOperatingTeams;
    using Testi2007.A.E.O.Interfaces.Parameters.TP.WardNumberOperatingTeams;

    public interface IeFactory
    {
        Ie Create(
            ImmutableList<IeParameterElement> value);
    }
}