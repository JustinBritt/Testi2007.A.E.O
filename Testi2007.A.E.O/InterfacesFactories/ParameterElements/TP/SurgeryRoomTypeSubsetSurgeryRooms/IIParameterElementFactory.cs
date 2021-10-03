namespace Testi2007.A.E.O.InterfacesFactories.ParameterElements.TP.SurgeryRoomTypeSubsetSurgeryRooms
{
    using Testi2007.A.E.O.Interfaces.IndexElements.TP;
    using Testi2007.A.E.O.Interfaces.ParameterElements.TP.SurgeryRoomTypeSubsetSurgeryRooms;

    public interface IIParameterElementFactory
    {
        IIParameterElement Create(
            IsIndexElement sIndexElement,
            IiIndexElement iIndexElement);
    }
}