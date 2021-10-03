namespace Testi2007.A.E.O.Factories.Constraints.TP
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Testi2007.A.E.O.Classes.Constraints.TP;
    using Testi2007.A.E.O.Interfaces.ConstraintElements.TP;
    using Testi2007.A.E.O.Interfaces.Constraints.TP;
    using Testi2007.A.E.O.InterfacesFactories.Constraints.TP;

    internal sealed class Constraints10Factory : IConstraints10Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints10Factory()
        {
        }

        public IConstraints10 Create(
            ImmutableList<IConstraints10ConstraintElement> value)
        {
            IConstraints10 constraint = null;

            try
            {
                constraint = new Constraints10(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return constraint;
        }
    }
}