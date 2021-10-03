namespace Testi2007.A.E.O.Factories.ObjectiveFunctions.SP
{
    using System;

    using log4net;

    using Testi2007.A.E.O.Classes.ObjectiveFunctions.SP;
    using Testi2007.A.E.O.Interfaces.CrossJoins.SP;
    using Testi2007.A.E.O.Interfaces.ObjectiveFunctions.SP;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.WardSessionDemandMarginalBenefits;
    using Testi2007.A.E.O.Interfaces.Variables.SP;
    using Testi2007.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;
    using Testi2007.A.E.O.InterfacesFactories.ObjectiveFunctions.SP;

    internal sealed class SPObjectiveFunctionFactory : ISPObjectiveFunctionFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SPObjectiveFunctionFactory()
        {
        }

        public ISPObjectiveFunction Create(
            IObjectiveFactory objectiveFactory,
            Ijk jk,
            Id d,
            ISPx x)
        {
            ISPObjectiveFunction objectiveFunction = null;

            try
            {
                objectiveFunction = new SPObjectiveFunction(
                    objectiveFactory,
                    jk,
                    d,
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