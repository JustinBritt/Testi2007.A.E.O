namespace Testi2007.A.E.O.InterfacesFactories.Constraints.TP
{
    using System.Collections.Immutable;

    using Testi2007.A.E.O.Interfaces.ConstraintElements.TP;
    using Testi2007.A.E.O.Interfaces.Constraints.TP;

    public interface IConstraints12Factory
    {
        IConstraints12 Create(
            ImmutableList<IConstraints12ConstraintElement> value);
    }
}