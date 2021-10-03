namespace Testi2007.A.E.O.InterfacesAbstractFactories
{
    using Testi2007.A.E.O.InterfacesFactories.Parameters.SP.DemandWeights;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.SP.NumberSessionBounds;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.SP.OverrunTimes;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.SP.WardDemands;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.SP.WardNumberSessionBounds;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.SP.WardOverrunTimes;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.SP.WardServiceRates;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.SP.WardSessionDemandMarginalBenefits;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.SP.WardWaitingLists;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.TP.SurgeryRoomTypeSubsetSurgeryRooms;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.TP.WardDayPreferences;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.TP.WardNumberAssignedSessions;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.TP.WardNumberOperatingTeams;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.TP.WardSurgeryRoomNumberSessionBounds;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.TP.WardWaitingLists;

    public interface IParametersAbstractFactory
    {
        IDFactory CreateDFactory();

        IdFactory CreatedFactory();

        IDLFactory CreateDLFactory();

        IDSFactory CreateDSFactory();

        IeFactory CreateeFactory();

        IHFactory CreateHFactory();

        IIFactory CreateIFactory();

        Testi2007.A.E.O.InterfacesFactories.Parameters.SP.WardNumberSessionBounds.IlFactory CreateSPlFactory();

        Testi2007.A.E.O.InterfacesFactories.Parameters.TP.WardSurgeryRoomNumberSessionBounds.IlFactory CreateTPlFactory();

        INFactory CreateNFactory();

        IoFactory CreateoFactory();

        IpFactory CreatepFactory();

        IqFactory CreateqFactory();

        IWLFactory CreateWLFactory();

        IWLLSFactory CreateWLLSFactory();

        IWLSSFactory CreateWLSSFactory();

        IαFactory CreateαFactory();

        IβFactory CreateβFactory();

        IμFactory CreateμFactory();
    }
}