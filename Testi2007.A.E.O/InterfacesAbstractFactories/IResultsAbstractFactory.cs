namespace Testi2007.A.E.O.InterfacesAbstractFactories
{
    using Testi2007.A.E.O.InterfacesFactories.Results.Common.BestBound;
    using Testi2007.A.E.O.InterfacesFactories.Results.Common.Gap;
    using Testi2007.A.E.O.InterfacesFactories.Results.Common.NumberOfExploredNodes;
    using Testi2007.A.E.O.InterfacesFactories.Results.Common.ObjectiveValue;
    using Testi2007.A.E.O.InterfacesFactories.Results.Common.OverallWallTime;
    using Testi2007.A.E.O.InterfacesFactories.Results.SP.SurgeonSessionAssignments;
    using Testi2007.A.E.O.InterfacesFactories.Results.TP.OperatingRoomWardDayAssignments;

    public interface IResultsAbstractFactory
    {
        IBestBoundFactory CreateBestBoundFactory();

        IGapFactory CreateGapFactory();

        INumberOfExploredNodesFactory CreateNumberOfExploredNodesFactory();

        IObjectiveValueFactory CreateObjectiveValueFactory();

        IOverallWallTimeFactory CreateOverallWallTimeFactory();

        ISPxFactory CreateSPxFactory();

        ITPxFactory CreateTPxFactory();
    }
}