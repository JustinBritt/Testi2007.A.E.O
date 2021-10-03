namespace Testi2007.A.E.O.InterfacesFactories.Results.TP.OperatingRoomWardDayAssignments
{
    using System.Collections.Immutable;

    using Testi2007.A.E.O.Interfaces.ResultElements.TP.OperatingRoomWardDayAssignments;
    using Testi2007.A.E.O.Interfaces.Results.TP.OperatingRoomWardDayAssignments;

    public interface ITPxFactory
    {
        ITPx Create(
            ImmutableList<ITPxResultElement> value);
    }
}