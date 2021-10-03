namespace Testi2007.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Testi2007.A.E.O.Factories.Variables.SP;
    using Testi2007.A.E.O.Factories.Variables.TP;
    using Testi2007.A.E.O.InterfacesFactories.Variables.SP;
    using Testi2007.A.E.O.InterfacesFactories.Variables.TP;
    using Testi2007.A.E.O.InterfacesAbstractFactories;

    internal sealed class VariablesAbstractFactory : IVariablesAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VariablesAbstractFactory()
        {
        }

        public Testi2007.A.E.O.InterfacesFactories.Variables.SP.ISPxFactory CreateSPxFactory()
        {
            Testi2007.A.E.O.InterfacesFactories.Variables.SP.ISPxFactory factory = null;

            try
            {
                factory = new Testi2007.A.E.O.Factories.Variables.SP.SPxFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public Testi2007.A.E.O.InterfacesFactories.Variables.TP.ITPxFactory CreateTPxFactory()
        {
            Testi2007.A.E.O.InterfacesFactories.Variables.TP.ITPxFactory factory = null;

            try
            {
                factory = new Testi2007.A.E.O.Factories.Variables.TP.TPxFactory();
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