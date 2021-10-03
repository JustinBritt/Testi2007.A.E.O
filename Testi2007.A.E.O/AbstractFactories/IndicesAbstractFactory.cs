namespace Testi2007.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Testi2007.A.E.O.Factories.Indices.Common;
    using Testi2007.A.E.O.Factories.Indices.SP;
    using Testi2007.A.E.O.Factories.Indices.TP;
    using Testi2007.A.E.O.InterfacesFactories.Indices.Common;
    using Testi2007.A.E.O.InterfacesFactories.Indices.SP;
    using Testi2007.A.E.O.InterfacesFactories.Indices.TP;
    using Testi2007.A.E.O.InterfacesAbstractFactories;

    internal sealed class IndicesAbstractFactory : IIndicesAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IndicesAbstractFactory()
        {
        }

        public IiFactory CreateiFactory()
        {
            IiFactory factory = null;

            try
            {
                factory = new iFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IjFactory CreatejFactory()
        {
            IjFactory factory = null;

            try
            {
                factory = new jFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IkFactory CreatekFactory()
        {
            IkFactory factory = null;

            try
            {
                factory = new kFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IsFactory CreatesFactory()
        {
            IsFactory factory = null;

            try
            {
                factory = new sFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IwFactory CreatewFactory()
        {
            IwFactory factory = null;

            try
            {
                factory = new wFactory();
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