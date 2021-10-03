namespace Testi2007.A.E.O.InterfacesFactories.Parameters.SP.WardServiceRates
{
    using System.Collections.Immutable;

    using Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardServiceRates;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.WardServiceRates;

    public interface IμFactory
    {
        Iμ Create(
            ImmutableList<IμParameterElement> value);
    }
}