namespace Testi2007.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Testi2007.A.E.O.Factories.CrossJoinElements.SP;
    using Testi2007.A.E.O.Factories.CrossJoinElements.TP;
    using Testi2007.A.E.O.InterfacesFactories.CrossJoinElements.SP;
    using Testi2007.A.E.O.InterfacesFactories.CrossJoinElements.TP;
    using Testi2007.A.E.O.InterfacesAbstractFactories;

    internal sealed class CrossJoinElementsAbstractFactory : ICrossJoinElementsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CrossJoinElementsAbstractFactory()
        {
        }

        public IijCrossJoinElementFactory CreateijCrossJoinElementFactory()
        {
            IijCrossJoinElementFactory factory = null;

            try
            {
                factory = new ijCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IijwCrossJoinElementFactory CreateijwCrossJoinElementFactory()
        {
            IijwCrossJoinElementFactory factory = null;

            try
            {
                factory = new ijwCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IiwCrossJoinElementFactory CreateiwCrossJoinElementFactory()
        {
            IiwCrossJoinElementFactory factory = null;

            try
            {
                factory = new iwCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IjkCrossJoinElementFactory CreatejkCrossJoinElementFactory()
        {
            IjkCrossJoinElementFactory factory = null;

            try
            {
                factory = new jkCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IjsCrossJoinElementFactory CreatejsCrossJoinElementFactory()
        {
            IjsCrossJoinElementFactory factory = null;

            try
            {
                factory = new jsCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IjwCrossJoinElementFactory CreatejwCrossJoinElementFactory()
        {
            IjwCrossJoinElementFactory factory = null;

            try
            {
                factory = new jwCrossJoinElementFactory();
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