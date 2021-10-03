namespace Testi2007.A.E.O.InterfacesFactories.Indices.SP
{
    using System.Collections.Immutable;

    using Testi2007.A.E.O.Interfaces.IndexElements.SP;
    using Testi2007.A.E.O.Interfaces.Indices.SP;

    public interface IkFactory
    {
        Ik Create(
            ImmutableList<IkIndexElement> value);
    }
}