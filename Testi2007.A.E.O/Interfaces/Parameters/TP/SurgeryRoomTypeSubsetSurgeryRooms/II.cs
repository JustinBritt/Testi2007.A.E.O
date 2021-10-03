namespace Testi2007.A.E.O.Interfaces.Parameters.TP.SurgeryRoomTypeSubsetSurgeryRooms
{
    using System.Collections.Immutable;

    using Testi2007.A.E.O.Interfaces.IndexElements.TP;
    using Testi2007.A.E.O.Interfaces.ParameterElements.TP.SurgeryRoomTypeSubsetSurgeryRooms;

    public interface II
    {
        ImmutableList<IIParameterElement> Value { get; }

        bool IsThereElementAt(
            IsIndexElement sIndexElement,
            IiIndexElement iIndexElement);
    }
}