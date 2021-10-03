namespace Testi2007.A.E.O.InterfacesFactories.Parameters.TP.SurgeryRoomTypeSubsetSurgeryRooms
{
    using System.Collections.Immutable;

    using Testi2007.A.E.O.Interfaces.ParameterElements.TP.SurgeryRoomTypeSubsetSurgeryRooms;
    using Testi2007.A.E.O.Interfaces.Parameters.TP.SurgeryRoomTypeSubsetSurgeryRooms;

    public interface IIFactory
    {
        II Create(
            ImmutableList<IIParameterElement> value);
    }
}