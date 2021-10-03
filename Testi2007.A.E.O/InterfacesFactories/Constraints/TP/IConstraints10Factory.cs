namespace Testi2007.A.E.O.InterfacesFactories.Constraints.TP
{
    using System.Collections.Immutable;

    using Testi2007.A.E.O.Interfaces.ConstraintElements.TP;
    using Testi2007.A.E.O.Interfaces.Constraints.TP;

    public interface IConstraints10Factory
    {
        IConstraints10 Create(
            ImmutableList<IConstraints10ConstraintElement> value);
    }
}