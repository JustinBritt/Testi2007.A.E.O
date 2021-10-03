namespace Testi2007.A.E.O.Factories.Calculations.SP.WardDemands
{
    using System;

    using log4net;

    using Testi2007.A.E.O.Classes.Calculations.SP.WardDemands;
    using Testi2007.A.E.O.Interfaces.Calculations.SP.WardDemands;
    using Testi2007.A.E.O.InterfacesFactories.Calculations.SP.WardDemands;

    internal sealed class DCalculationFactory : IDCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DCalculationFactory()
        {
        }

        public IDCalculation Create()
        {
            IDCalculation calculation = null;

            try
            {
                calculation = new DCalculation();
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