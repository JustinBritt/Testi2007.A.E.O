namespace Testi2007.A.E.O.Interfaces.Constraints.SP
{
    using System.Collections.Immutable;

    using Testi2007.A.E.O.Interfaces.ConstraintElements.SP;

    public interface IConstraints4
    {
        ImmutableList<IConstraints4ConstraintElement> Value { get; }
    }
}