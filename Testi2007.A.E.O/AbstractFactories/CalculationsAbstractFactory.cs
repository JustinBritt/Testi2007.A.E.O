namespace Testi2007.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Testi2007.A.E.O.Factories.Calculations.SP.WardDemands;
    using Testi2007.A.E.O.Factories.Calculations.SP.WardSessionDemandMarginalBenefits;
    using Testi2007.A.E.O.Factories.Calculations.TP.WardDayPreferences;
    using Testi2007.A.E.O.Factories.Calculations.TP.WardNumberOperatingTeams;
    using Testi2007.A.E.O.InterfacesFactories.Calculations.SP.WardDemands;
    using Testi2007.A.E.O.InterfacesFactories.Calculations.SP.WardSessionDemandMarginalBenefits;
    using Testi2007.A.E.O.InterfacesFactories.Calculations.TP.WardDayPreferences;
    using Testi2007.A.E.O.InterfacesFactories.Calculations.TP.WardNumberOperatingTeams;
    using Testi2007.A.E.O.InterfacesAbstractFactories;

    internal sealed class CalculationsAbstractFactory : ICalculationsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CalculationsAbstractFactory()
        {
        }

        public IDCalculationFactory CreateDCalculationFactory()
        {
            IDCalculationFactory factory = null;

            try
            {
                factory = new DCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IdCalculationFactory CreatedCalculationFactory()
        {
            IdCalculationFactory factory = null;

            try
            {
                factory = new dCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IDLCalculationFactory CreateDLCalculationFactory()
        {
            IDLCalculationFactory factory = null;

            try
            {
                factory = new DLCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IeCalculationFactory CreateeCalculationFactory()
        {
            IeCalculationFactory factory = null;

            try
            {
                factory = new eCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IpCalculationFactory CreatepCalculationFactory()
        {
            IpCalculationFactory factory = null;

            try
            {
                factory = new pCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }
    }
}