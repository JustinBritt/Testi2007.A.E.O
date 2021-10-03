namespace Testi2007.A.E.O.Factories.Calculations.TP.WardNumberOperatingTeams
{
    using System;

    using log4net;

    using Testi2007.A.E.O.Classes.Calculations.TP.WardNumberOperatingTeams;
    using Testi2007.A.E.O.Interfaces.Calculations.TP.WardNumberOperatingTeams;
    using Testi2007.A.E.O.InterfacesFactories.Calculations.TP.WardNumberOperatingTeams;

    internal sealed class eCalculationFactory : IeCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public eCalculationFactory()
        {
        }

        public IeCalculation Create()
        {
            IeCalculation calculation = null;

            try
            {
                calculation = new eCalculation();
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