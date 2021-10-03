namespace Testi2007.A.E.O.Factories.Calculations.TP.WardDayPreferences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Testi2007.A.E.O.Classes.Calculations.TP.WardDayPreferences;
    using Testi2007.A.E.O.Interfaces.Calculations.TP.WardDayPreferences;
    using Testi2007.A.E.O.InterfacesFactories.Calculations.TP.WardDayPreferences;

    internal sealed class pCalculationFactory : IpCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public pCalculationFactory()
        {
        }

        public IpCalculation Create()
        {
            IpCalculation calculation = null;

            try
            {
                calculation = new pCalculation();
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