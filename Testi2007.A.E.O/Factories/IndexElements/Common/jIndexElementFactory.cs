namespace Testi2007.A.E.O.Factories.IndexElements.Common
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Classes.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.InterfacesFactories.IndexElements.Common;

    internal sealed class jIndexElementFactory : IjIndexElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);    

        public jIndexElementFactory()
        {
        }

        public IjIndexElement Create(
            Organization value)
        {
            IjIndexElement indexElement = null;

            try
            {
                indexElement = new jIndexElement(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return indexElement;
        }
    }
}