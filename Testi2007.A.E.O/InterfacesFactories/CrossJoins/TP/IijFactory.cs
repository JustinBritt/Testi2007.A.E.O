namespace Testi2007.A.E.O.InterfacesFactories.CrossJoins.TP
{
    using System.Collections.Immutable;

    using Testi2007.A.E.O.Interfaces.CrossJoinElements.TP;
    using Testi2007.A.E.O.Interfaces.CrossJoins.TP;

    public interface IijFactory
    {
        Iij Create(
            ImmutableList<IijCrossJoinElement> value);
    }
}