namespace Testi2007.A.E.O.InterfacesFactories.Constraints.SP
{
    using Testi2007.A.E.O.Interfaces.Constraints.SP;
    using Testi2007.A.E.O.Interfaces.CrossJoins.SP;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.NumberSessionBounds;
    using Testi2007.A.E.O.Interfaces.Variables.SP;

    public interface IConstraint3Factory
    {
        IConstraint3 Create(
            Ijk jk,
            Iq q,
            ISPx x);
    }
}