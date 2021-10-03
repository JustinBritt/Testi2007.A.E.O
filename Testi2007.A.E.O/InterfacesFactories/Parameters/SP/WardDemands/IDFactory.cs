namespace Testi2007.A.E.O.InterfacesFactories.Parameters.SP.WardDemands
{
    using System.Collections.Immutable;

    using Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardDemands;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.WardDemands;

    public interface IDFactory
    {
        ID Create(
            ImmutableList<IDParameterElement> value);
    }
}