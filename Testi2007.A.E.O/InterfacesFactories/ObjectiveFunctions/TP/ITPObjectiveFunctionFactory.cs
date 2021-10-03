namespace Testi2007.A.E.O.InterfacesFactories.ObjectiveFunctions.TP
{
    using Testi2007.A.E.O.Interfaces.CrossJoins.TP;
    using Testi2007.A.E.O.Interfaces.ObjectiveFunctions.TP;
    using Testi2007.A.E.O.Interfaces.Parameters.TP.WardDayPreferences;
    using Testi2007.A.E.O.Interfaces.Variables.TP;
    using Testi2007.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;

    public interface ITPObjectiveFunctionFactory
    {
        ITPObjectiveFunction Create(
            IObjectiveFactory objectiveFactory,
            Iijw ijw,
            Ip p,
            ITPx x);
    }
}