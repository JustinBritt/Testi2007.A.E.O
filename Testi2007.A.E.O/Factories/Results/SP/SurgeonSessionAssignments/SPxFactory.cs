namespace Testi2007.A.E.O.Factories.Results.SP.SurgeonSessionAssignments
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Testi2007.A.E.O.Classes.Results.SP.SurgeonSessionAssignments;
    using Testi2007.A.E.O.Interfaces.ResultElements.SP.SurgeonSessionAssignments;
    using Testi2007.A.E.O.Interfaces.Results.SP.SurgeonSessionAssignments;
    using Testi2007.A.E.O.InterfacesFactories.Results.SP.SurgeonSessionAssignments;

    internal sealed class SPxFactory : ISPxFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SPxFactory()
        {
        }

        public ISPx Create(
            ImmutableList<ISPxResultElement> value)
        {
            ISPx solution = null;

            try
            {
                solution = new SPx(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return solution;
        }
    }
}