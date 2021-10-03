namespace Testi2007.A.E.O.Interfaces.Constraints.TP
{
    using System.Collections.Immutable;

    using Testi2007.A.E.O.Interfaces.ConstraintElements.TP;

    public interface IConstraints11
    {
        ImmutableList<IConstraints11ConstraintElement> Value { get; }
    }
}