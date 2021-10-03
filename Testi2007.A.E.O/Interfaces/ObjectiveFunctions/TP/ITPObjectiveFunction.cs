namespace Testi2007.A.E.O.Interfaces.ObjectiveFunctions.TP
{
    using OPTANO.Modeling.Optimization;

    public interface ITPObjectiveFunction
    {
        Objective Value { get; }
    }
}