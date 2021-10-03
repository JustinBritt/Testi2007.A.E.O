namespace Testi2007.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Testi2007.A.E.O.Factories.ConstraintElements.SP;
    using Testi2007.A.E.O.Factories.ConstraintElements.TP;
    using Testi2007.A.E.O.InterfacesFactories.ConstraintElements.SP;
    using Testi2007.A.E.O.InterfacesFactories.ConstraintElements.TP;
    using Testi2007.A.E.O.InterfacesAbstractFactories;

    internal sealed class ConstraintElementsAbstractFactory : IConstraintElementsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ConstraintElementsAbstractFactory()
        {
        }

        public IConstraints4ConstraintElementFactory CreateConstraints4ConstraintElementFactory()
        {
            IConstraints4ConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints4ConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints9ConstraintElementFactory CreateConstraints9ConstraintElementFactory()
        {
            IConstraints9ConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints9ConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints10ConstraintElementFactory CreateConstraints10ConstraintElementFactory()
        {
            IConstraints10ConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints10ConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints11ConstraintElementFactory CreateConstraints11ConstraintElementFactory()
        {
            IConstraints11ConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints11ConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints12ConstraintElementFactory CreateConstraints12ConstraintElementFactory()
        {
            IConstraints12ConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints12ConstraintElementFactory();
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