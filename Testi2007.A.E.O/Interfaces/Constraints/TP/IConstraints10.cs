namespace Testi2007.A.E.O.Interfaces.Constraints.TP
{
    using System.Collections.Immutable;

    using Testi2007.A.E.O.Interfaces.ConstraintElements.TP;

    public interface IConstraints10
    {
        ImmutableList<IConstraints10ConstraintElement> Value { get; }
    }
}