namespace Testi2007.A.E.O.Factories.ObjectiveFunctions.TP
{
    using System;

    using log4net;

    using Testi2007.A.E.O.Classes.ObjectiveFunctions.TP;
    using Testi2007.A.E.O.Interfaces.CrossJoins.TP;
    using Testi2007.A.E.O.Interfaces.ObjectiveFunctions.TP;
    using Testi2007.A.E.O.Interfaces.Parameters.TP.WardDayPreferences;
    using Testi2007.A.E.O.Interfaces.Variables.TP;
    using Testi2007.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;
    using Testi2007.A.E.O.InterfacesFactories.ObjectiveFunctions.TP;

    internal sealed class TPObjectiveFunctionFactory : ITPObjectiveFunctionFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TPObjectiveFunctionFactory()
        {
        }

        public ITPObjectiveFunction Create(
            IObjectiveFactory objectiveFactory,
            Iijw ijw,
            Ip p,
            ITPx x)
        {
            ITPObjectiveFunction objectiveFunction = null;

            try
            {
                objectiveFunction = new TPObjectiveFunction(
                    objectiveFactory,
                    ijw,
                    p,
                    x);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return objectiveFunction;
        }
    }
}