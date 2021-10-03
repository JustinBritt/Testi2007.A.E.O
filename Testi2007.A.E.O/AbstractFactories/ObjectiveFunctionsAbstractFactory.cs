namespace Testi2007.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Testi2007.A.E.O.Factories.ObjectiveFunctions.SP;
    using Testi2007.A.E.O.Factories.ObjectiveFunctions.TP;
    using Testi2007.A.E.O.InterfacesFactories.ObjectiveFunctions.SP;
    using Testi2007.A.E.O.InterfacesFactories.ObjectiveFunctions.TP;
    using Testi2007.A.E.O.InterfacesAbstractFactories;

    internal sealed class ObjectiveFunctionsAbstractFactory : IObjectiveFunctionsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ObjectiveFunctionsAbstractFactory()
        {
        }

        public ISPObjectiveFunctionFactory CreateSPObjectiveFunctionFactory()
        {
            ISPObjectiveFunctionFactory factory = null;

            try
            {
                factory = new SPObjectiveFunctionFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ITPObjectiveFunctionFactory CreateTPObjectiveFunctionFactory()
        {
            ITPObjectiveFunctionFactory factory = null;

            try
            {
                factory = new TPObjectiveFunctionFactory();
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