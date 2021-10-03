namespace Testi2007.A.E.O.InterfacesAbstractFactories
{
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.SP.WardDemands;
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.SP.WardNumberSessionBounds;
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.SP.WardOverrunTimes;
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.SP.WardServiceRates;
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.SP.WardSessionDemandMarginalBenefits;
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.SP.WardWaitingLists;
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.TP.SurgeryRoomTypeSubsetSurgeryRooms;
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.TP.WardDayPreferences;
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.TP.WardNumberAssignedSessions;
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.TP.WardNumberOperatingTeams;
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.TP.WardSurgeryRoomNumberSessionBounds;
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.TP.WardWaitingLists;

    public interface IParameterElementsAbstractFactory
    {
        IDParameterElementFactory CreateDParameterElementFactory();

        IdParameterElementFactory CreatedParameterElementFactory();

        IDLParameterElementFactory CreateDLParameterElementFactory();

        IDSParameterElementFactory CreateDSParameterElementFactory();

        IeParameterElementFactory CreateeParameterElementFactory();

        IIParameterElementFactory CreateIParameterElementFactory();

        Testi2007.A.E.O.InterfacesFactories.ParameterElements.SP.WardNumberSessionBounds.IlParameterElementFactory CreateSPlParameterElementFactory();

        Testi2007.A.E.O.InterfacesFactories.ParameterElements.TP.WardSurgeryRoomNumberSessionBounds.IlParameterElementFactory CreateTPlParameterElementFactory();

        INParameterElementFactory CreateNParameterElementFactory();

        IoParameterElementFactory CreateoParameterElementFactory();

        IpParameterElementFactory CreatepParameterElementFactory();

        IWLParameterElementFactory CreateWLParameterElementFactory();

        IWLLSParameterElementFactory CreateWLLSParameterElementFactory();

        IWLSSParameterElementFactory CreateWLSSParameterElementFactory();

        IμParameterElementFactory CreateμParameterElementFactory();
    }
}