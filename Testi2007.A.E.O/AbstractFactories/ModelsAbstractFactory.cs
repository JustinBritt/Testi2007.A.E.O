namespace Testi2007.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Testi2007.A.E.O.Factories.Models.SP;
    using Testi2007.A.E.O.Factories.Models.TP;
    using Testi2007.A.E.O.InterfacesFactories.Models.SP;
    using Testi2007.A.E.O.InterfacesFactories.Models.TP;
    using Testi2007.A.E.O.InterfacesAbstractFactories;

    internal sealed class ModelsAbstractFactory : IModelsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ModelsAbstractFactory()
        {
        }

        public ISPModelFactory CreateSPModelFactory()
        {
            ISPModelFactory factory = null;

            try
            {
                factory = new SPModelFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ITPModelFactory CreateTPModelFactory()
        {
            ITPModelFactory factory = null;

            try
            {
                factory = new TPModelFactory();
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