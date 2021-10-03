namespace Testi2007.A.E.O.Factories.Constraints.SP
{
    using System;

    using log4net;

    using Testi2007.A.E.O.Classes.Constraints.SP;
    using Testi2007.A.E.O.Interfaces.Constraints.SP;
    using Testi2007.A.E.O.Interfaces.CrossJoins.SP;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.NumberSessionBounds;
    using Testi2007.A.E.O.Interfaces.Variables.SP;
    using Testi2007.A.E.O.InterfacesFactories.Constraints.SP;

    internal sealed class Constraint3Factory : IConstraint3Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraint3Factory()
        {
        }

        public IConstraint3 Create(
            Ijk jk,
            Iq q,
            ISPx x)
        {
            IConstraint3 constraint = null;

            try
            {
                constraint = new Constraint3(
                    jk,
                    q,
                    x);
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