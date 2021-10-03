namespace Testi2007.A.E.O.InterfacesFactories.ConstraintElements.TP
{
    using Testi2007.A.E.O.Interfaces.ConstraintElements.TP;
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.TP;
    using Testi2007.A.E.O.Interfaces.Indices.TP;
    using Testi2007.A.E.O.Interfaces.Parameters.TP.WardNumberOperatingTeams;
    using Testi2007.A.E.O.Interfaces.Variables.TP;

    public interface IConstraints10ConstraintElementFactory
    {
        IConstraints10ConstraintElement Create(
            IjIndexElement jIndexElement,
            IwIndexElement wIndexElement,
            Ii i,
            Ie e,
            ITPx x);
    }
}