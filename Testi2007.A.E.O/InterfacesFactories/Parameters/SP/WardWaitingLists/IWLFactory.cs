namespace Testi2007.A.E.O.InterfacesFactories.Parameters.SP.WardWaitingLists
{
    using System.Collections.Immutable;

    using Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardWaitingLists;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.WardWaitingLists;

    public interface IWLFactory
    {
        IWL Create(
            ImmutableList<IWLParameterElement> value);
    }
}