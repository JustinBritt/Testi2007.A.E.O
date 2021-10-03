namespace Testi2007.A.E.O.Factories.ResultElements.SP.SurgeonSessionAssignments
{
    using System;

    using log4net;

    using Testi2007.A.E.O.Classes.ResultElements.SP.SurgeonSessionAssignments;
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.SP;
    using Testi2007.A.E.O.Interfaces.ResultElements.SP.SurgeonSessionAssignments;
    using Testi2007.A.E.O.InterfacesFactories.ResultElements.SP.SurgeonSessionAssignments;

    internal sealed class SPxResultElementFactory : ISPxResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SPxResultElementFactory()
        {
        }

        public ISPxResultElement Create(
            IjIndexElement jIndexElement,
            IkIndexElement kIndexElement,
            bool value)
        {
            ISPxResultElement solution = null;

            try
            {
                solution = new SPxResultElement(
                    jIndexElement,
                    kIndexElement,
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