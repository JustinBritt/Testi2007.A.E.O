namespace Testi2007.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Testi2007.A.E.O.Factories.Solutions.SP;
    using Testi2007.A.E.O.Factories.Solutions.TP;
    using Testi2007.A.E.O.InterfacesFactories.Solutions.SP;
    using Testi2007.A.E.O.InterfacesFactories.Solutions.TP;
    using Testi2007.A.E.O.InterfacesAbstractFactories;

    internal sealed class SolutionsAbstractFactory : ISolutionsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SolutionsAbstractFactory()
        {
        }

        public ISPSolutionFactory CreateSPSolutionFactory()
        {
            ISPSolutionFactory factory = null;

            try
            {
                factory = new SPSolutionFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ITPSolutionFactory CreateTPSolutionFactory()
        {
            ITPSolutionFactory factory = null;

            try
            {
                factory = new TPSolutionFactory();
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