namespace Testi2007.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Testi2007.A.E.O.Factories.CrossJoins.SP;
    using Testi2007.A.E.O.Factories.CrossJoins.TP;
    using Testi2007.A.E.O.InterfacesFactories.CrossJoins.SP;
    using Testi2007.A.E.O.InterfacesFactories.CrossJoins.TP;
    using Testi2007.A.E.O.InterfacesAbstractFactories;

    internal sealed class CrossJoinsAbstractFactory : ICrossJoinsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CrossJoinsAbstractFactory()
        {
        }

        public IijFactory CreateijFactory()
        {
            IijFactory factory = null;

            try
            {
                factory = new ijFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IijwFactory CreateijwFactory()
        {
            IijwFactory factory = null;

            try
            {
                factory = new ijwFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IiwFactory CreateiwFactory()
        {
            IiwFactory factory = null;

            try
            {
                factory = new iwFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IjkFactory CreatejkFactory()
        {
            IjkFactory factory = null;

            try
            {
                factory = new jkFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IjsFactory CreatejsFactory()
        {
            IjsFactory factory = null;

            try
            {
                factory = new jsFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IjwFactory CreatejwFactory()
        {
            IjwFactory factory = null;

            try
            {
                factory = new jwFactory();
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