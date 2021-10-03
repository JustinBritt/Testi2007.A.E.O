namespace Testi2007.A.E.O.InterfacesFactories.Constraints.SP
{
    using Testi2007.A.E.O.Interfaces.Constraints.SP;
    using Testi2007.A.E.O.Interfaces.CrossJoins.SP;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.OverrunTimes;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.WardOverrunTimes;
    using Testi2007.A.E.O.Interfaces.Variables.SP;

    public interface IConstraint5Factory
    {
        IConstraint5 Create(
            Ijk jk,
            IH H,
            Io o,
            ISPx x);
    }
}