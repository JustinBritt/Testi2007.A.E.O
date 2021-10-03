namespace Testi2007.A.E.O.InterfacesFactories.Constraints.SP
{
    using System.Collections.Immutable;

    using Testi2007.A.E.O.Interfaces.ConstraintElements.SP;
    using Testi2007.A.E.O.Interfaces.Constraints.SP;

    public interface IConstraints4Factory
    {
        IConstraints4 Create(
            ImmutableList<IConstraints4ConstraintElement> value);
    }
}