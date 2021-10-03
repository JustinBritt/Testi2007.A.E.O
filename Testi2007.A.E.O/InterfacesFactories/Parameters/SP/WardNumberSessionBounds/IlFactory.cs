namespace Testi2007.A.E.O.InterfacesFactories.Parameters.SP.WardNumberSessionBounds
{
    using System.Collections.Immutable;

    using Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardNumberSessionBounds;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.WardNumberSessionBounds;

    public interface IlFactory
    {
        Il Create(
            ImmutableList<IlParameterElement> value);
    }
}