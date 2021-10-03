namespace Testi2007.A.E.O.InterfacesFactories.ResultElements.TP.OperatingRoomWardDayAssignments
{
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.TP;
    using Testi2007.A.E.O.Interfaces.ResultElements.TP.OperatingRoomWardDayAssignments;

    public interface ITPxResultElementFactory
    {
        ITPxResultElement Create(
            IiIndexElement iIndexElement,
            IjIndexElement jIndexElement,
            IwIndexElement wIndexElement,
            bool value);
    }
}