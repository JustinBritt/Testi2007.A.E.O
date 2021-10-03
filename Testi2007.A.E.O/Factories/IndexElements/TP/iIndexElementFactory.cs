namespace Testi2007.A.E.O.Factories.IndexElements.TP
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Classes.IndexElements.TP;
    using Testi2007.A.E.O.Interfaces.IndexElements.TP;
    using Testi2007.A.E.O.InterfacesFactories.IndexElements.TP;

    internal sealed class iIndexElementFactory : IiIndexElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public iIndexElementFactory()
        {
        }

        public IiIndexElement Create(
            Location value)
        {
            IiIndexElement indexElement = null;

            try
            {
                indexElement = new iIndexElement(
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