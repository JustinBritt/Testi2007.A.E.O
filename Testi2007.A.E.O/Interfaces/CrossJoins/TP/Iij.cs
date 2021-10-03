namespace Testi2007.A.E.O.Interfaces.CrossJoins.TP
{
    using System.Collections.Immutable;

    using Testi2007.A.E.O.Interfaces.CrossJoinElements.TP;

    public interface Iij
    {
        ImmutableList<IijCrossJoinElement> Value { get; }
    }
}