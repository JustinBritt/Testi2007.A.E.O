namespace Testi2007.A.E.O.Factories.Constraints.SP
{
    using System;

    using log4net;

    using Testi2007.A.E.O.Classes.Constraints.SP;
    using Testi2007.A.E.O.Interfaces.Constraints.SP;
    using Testi2007.A.E.O.Interfaces.CrossJoins.SP;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.OverrunTimes;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.WardOverrunTimes;
    using Testi2007.A.E.O.Interfaces.Variables.SP;
    using Testi2007.A.E.O.InterfacesFactories.Constraints.SP;

    internal sealed class Constraint5Factory : IConstraint5Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraint5Factory()
        {
        }

        public IConstraint5 Create(
            Ijk jk,
            IH H,
            Io o,
            ISPx x)
        {
            IConstraint5 constraint = null;

            try
            {
                constraint = new Constraint5(
                    jk,
                    H,
                    o,
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