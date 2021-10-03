namespace Testi2007.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Testi2007.A.E.O.Factories.Constraints.SP;
    using Testi2007.A.E.O.Factories.Constraints.TP;
    using Testi2007.A.E.O.InterfacesFactories.Constraints.SP;
    using Testi2007.A.E.O.InterfacesFactories.Constraints.TP;
    using Testi2007.A.E.O.InterfacesAbstractFactories;

    internal sealed class ConstraintsAbstractFactory : IConstraintsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ConstraintsAbstractFactory()
        {
        }

        public IConstraint3Factory CreateConstraint3Factory()
        {
            IConstraint3Factory factory = null;

            try
            {
                factory = new Constraint3Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints4Factory CreateConstraints4Factory()
        {
            IConstraints4Factory factory = null;

            try
            {
                factory = new Constraints4Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraint5Factory CreateConstraint5Factory()
        {
            IConstraint5Factory factory = null;

            try
            {
                factory = new Constraint5Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints9Factory CreateConstraints9Factory()
        {
            IConstraints9Factory factory = null;

            try
            {
                factory = new Constraints9Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints10Factory CreateConstraints10Factory()
        {
            IConstraints10Factory factory = null;

            try
            {
                factory = new Constraints10Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints11Factory CreateConstraints11Factory()
        {
            IConstraints11Factory factory = null;

            try
            {
                factory = new Constraints11Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints12Factory CreateConstraints12Factory()
        {
            IConstraints12Factory factory = null;

            try
            {
                factory = new Constraints12Factory();
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