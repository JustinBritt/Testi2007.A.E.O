namespace Testi2007.A.E.O.InterfacesAbstractFactories
{
    using Testi2007.A.E.O.InterfacesFactories.ResultElements.SP.SurgeonSessionAssignments;
    using Testi2007.A.E.O.InterfacesFactories.ResultElements.TP.OperatingRoomWardDayAssignments;

    public interface IResultElementsAbstractFactory
    {
        ISPxResultElementFactory CreateSPxResultElementFactory();

        ITPxResultElementFactory CreateTPxResultElementFactory();
    }
}