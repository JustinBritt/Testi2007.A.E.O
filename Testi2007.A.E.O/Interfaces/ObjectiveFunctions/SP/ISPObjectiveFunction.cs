namespace Testi2007.A.E.O.Interfaces.ObjectiveFunctions.SP
{
    using OPTANO.Modeling.Optimization;

    public interface ISPObjectiveFunction
    {
        Objective Value { get; }
    }
}