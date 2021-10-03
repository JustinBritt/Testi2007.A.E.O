namespace Testi2007.A.E.O.InterfacesFactories.ConstraintElements.SP
{
    using Testi2007.A.E.O.Interfaces.ConstraintElements.SP;
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.Indices.SP;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.WardNumberSessionBounds;
    using Testi2007.A.E.O.Interfaces.Variables.SP;

    public interface IConstraints4ConstraintElementFactory
    {
        IConstraints4ConstraintElement Create(
            IjIndexElement jIndexElement,
            Ik k,
            Il l,
            ISPx x);
    }
}