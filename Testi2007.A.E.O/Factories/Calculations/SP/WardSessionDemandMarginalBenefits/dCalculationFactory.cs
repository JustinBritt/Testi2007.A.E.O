namespace Testi2007.A.E.O.Factories.Calculations.SP.WardSessionDemandMarginalBenefits
{
    using System;

    using log4net;

    using Testi2007.A.E.O.Classes.Calculations.SP.WardSessionDemandMarginalBenefits;
    using Testi2007.A.E.O.Interfaces.Calculations.SP.WardSessionDemandMarginalBenefits;
    using Testi2007.A.E.O.InterfacesFactories.Calculations.SP.WardSessionDemandMarginalBenefits;

    internal sealed class dCalculationFactory : IdCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public dCalculationFactory()
        {
        }

        public IdCalculation Create()
        {
            IdCalculation calculation = null;

            try
            {
                calculation = new dCalculation();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return calculation;
        }
    }
}