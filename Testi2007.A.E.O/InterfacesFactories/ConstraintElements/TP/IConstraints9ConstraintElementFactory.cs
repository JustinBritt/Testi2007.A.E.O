namespace Testi2007.A.E.O.InterfacesFactories.ConstraintElements.TP
{
    using Testi2007.A.E.O.Interfaces.ConstraintElements.TP;
    using Testi2007.A.E.O.Interfaces.IndexElements.TP;
    using Testi2007.A.E.O.Interfaces.Indices.Common;
    using Testi2007.A.E.O.Interfaces.Variables.TP;

    public interface IConstraints9ConstraintElementFactory
    {
        IConstraints9ConstraintElement Create(
            IiIndexElement iIndexElement,
            IwIndexElement wIndexElement,
            Ij j,
            ITPx x);
    }
}