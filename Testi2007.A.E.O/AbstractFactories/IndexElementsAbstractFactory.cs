namespace Testi2007.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Testi2007.A.E.O.Factories.IndexElements.Common;
    using Testi2007.A.E.O.Factories.IndexElements.SP;
    using Testi2007.A.E.O.Factories.IndexElements.TP;
    using Testi2007.A.E.O.InterfacesFactories.IndexElements.Common;
    using Testi2007.A.E.O.InterfacesFactories.IndexElements.SP;
    using Testi2007.A.E.O.InterfacesFactories.IndexElements.TP;
    using Testi2007.A.E.O.InterfacesAbstractFactories;

    internal sealed class IndexElementsAbstractFactory : IIndexElementsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IndexElementsAbstractFactory()
        {
        }

        public IiIndexElementFactory CreateiIndexElementFactory()
        {
            IiIndexElementFactory factory = null;

            try
            {
                factory = new iIndexElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IjIndexElementFactory CreatejIndexElementFactory()
        {
            IjIndexElementFactory factory = null;

            try
            {
                factory = new jIndexElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IkIndexElementFactory CreatekIndexElementFactory()
        {
            IkIndexElementFactory factory = null;

            try
            {
                factory = new kIndexElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IsIndexElementFactory CreatesIndexElementFactory()
        {
            IsIndexElementFactory factory = null;

            try
            {
                factory = new sIndexElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IwIndexElementFactory CreatewIndexElementFactory()
        {
            IwIndexElementFactory factory = null;

            try
            {
                factory = new wIndexElementFactory();
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