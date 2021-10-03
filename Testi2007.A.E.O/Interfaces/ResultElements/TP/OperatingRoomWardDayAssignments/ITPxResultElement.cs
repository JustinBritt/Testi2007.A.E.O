namespace Testi2007.A.E.O.Interfaces.ResultElements.TP.OperatingRoomWardDayAssignments
{
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.TP;

    public interface ITPxResultElement
    {
        IiIndexElement iIndexElement { get; }

        IjIndexElement jIndexElement { get; }

        IwIndexElement wIndexElement { get; }

        bool Value { get; }
    }
}