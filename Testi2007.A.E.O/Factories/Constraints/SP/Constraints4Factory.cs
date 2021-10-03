namespace Testi2007.A.E.O.Factories.Constraints.SP
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Testi2007.A.E.O.Classes.Constraints.SP;
    using Testi2007.A.E.O.Interfaces.ConstraintElements.SP;
    using Testi2007.A.E.O.Interfaces.Constraints.SP;
    using Testi2007.A.E.O.InterfacesFactories.Constraints.SP;

    internal sealed class Constraints4Factory : IConstraints4Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints4Factory()
        {
        }

        public IConstraints4 Create(
            ImmutableList<IConstraints4ConstraintElement> value)
        {
            IConstraints4 constraint = null;

            try
            {
                constraint = new Constraints4(
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