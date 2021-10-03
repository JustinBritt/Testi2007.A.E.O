namespace Testi2007.A.E.O.InterfacesFactories.ConstraintElements.TP
{
    using Testi2007.A.E.O.Interfaces.ConstraintElements.TP;
    using Testi2007.A.E.O.Interfaces.CrossJoins.TP;
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.Parameters.TP.WardNumberAssignedSessions;
    using Testi2007.A.E.O.Interfaces.Variables.TP;

    public interface IConstraints11ConstraintElementFactory
    {
        IConstraints11ConstraintElement Create(
            IjIndexElement jIndexElement,
            Iiw iw,
            IN N,
            ITPx x);
    }
}