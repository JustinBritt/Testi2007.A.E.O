namespace Testi2007.A.E.O.InterfacesFactories.Parameters.TP.WardWaitingLists
{
    using System.Collections.Immutable;

    using Testi2007.A.E.O.Interfaces.ParameterElements.TP.WardWaitingLists;
    using Testi2007.A.E.O.Interfaces.Parameters.TP.WardWaitingLists;

    public interface IWLSSFactory
    {
        IWLSS Create(
            ImmutableList<IWLSSParameterElement> value);
    }
}