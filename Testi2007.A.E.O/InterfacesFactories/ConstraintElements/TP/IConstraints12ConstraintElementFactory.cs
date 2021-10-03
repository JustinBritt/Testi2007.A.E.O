namespace Testi2007.A.E.O.InterfacesFactories.ConstraintElements.TP
{
    using Testi2007.A.E.O.Interfaces.ConstraintElements.TP;
    using Testi2007.A.E.O.Interfaces.CrossJoins.TP;
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.TP;
    using Testi2007.A.E.O.Interfaces.Parameters.TP.SurgeryRoomTypeSubsetSurgeryRooms;
    using Testi2007.A.E.O.Interfaces.Parameters.TP.WardSurgeryRoomNumberSessionBounds;
    using Testi2007.A.E.O.Interfaces.Variables.TP;

    public interface IConstraints12ConstraintElementFactory
    {
        IConstraints12ConstraintElement Create(
            IjIndexElement jIndexElement,
            IsIndexElement sIndexElement,
            Iiw iw,
            II I,
            Il l,
            ITPx x);
    }
}