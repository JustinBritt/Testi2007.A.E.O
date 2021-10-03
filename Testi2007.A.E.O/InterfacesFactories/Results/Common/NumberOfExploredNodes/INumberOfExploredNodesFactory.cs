namespace Testi2007.A.E.O.InterfacesFactories.Results.Common.NumberOfExploredNodes
{
    using Testi2007.A.E.O.Interfaces.Results.Common.NumberOfExploredNodes;

    public interface INumberOfExploredNodesFactory
    {
        INumberOfExploredNodes Create(
            long value);
    }
}