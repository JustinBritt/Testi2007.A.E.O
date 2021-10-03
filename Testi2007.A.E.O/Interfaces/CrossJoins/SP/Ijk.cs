namespace Testi2007.A.E.O.Interfaces.CrossJoins.SP
{
    using System.Collections.Immutable;

    using Testi2007.A.E.O.Interfaces.CrossJoinElements.SP;

    public interface Ijk
    {
        ImmutableList<IjkCrossJoinElement> Value { get; }
    }
}