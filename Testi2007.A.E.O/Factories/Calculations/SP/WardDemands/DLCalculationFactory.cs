namespace Testi2007.A.E.O.Factories.Calculations.SP.WardDemands
{
    using System;

    using log4net;

    using Testi2007.A.E.O.Classes.Calculations.SP.WardDemands;
    using Testi2007.A.E.O.Interfaces.Calculations.SP.WardDemands;
    using Testi2007.A.E.O.InterfacesFactories.Calculations.SP.WardDemands;

    internal sealed class DLCalculationFactory : IDLCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DLCalculationFactory()
        {
        }

        public IDLCalculation Create()
        {
            IDLCalculation calculation = null;

            try
            {
                calculation = new DLCalculation();
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