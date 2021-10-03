namespace Testi2007.A.E.O.InterfacesFactories.CrossJoins.SP
{
    using System.Collections.Immutable;

    using Testi2007.A.E.O.Interfaces.CrossJoinElements.SP;
    using Testi2007.A.E.O.Interfaces.CrossJoins.SP;

    public interface IjkFactory
    {
        Ijk Create(
            ImmutableList<IjkCrossJoinElement> value);
    }
}