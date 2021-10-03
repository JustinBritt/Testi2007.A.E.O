namespace Testi2007.A.E.O.Factories.IndexElements.SP
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Classes.IndexElements.SP;
    using Testi2007.A.E.O.Interfaces.IndexElements.SP;
    using Testi2007.A.E.O.InterfacesFactories.IndexElements.SP;

    internal sealed class kIndexElementFactory : IkIndexElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public kIndexElementFactory()
        {
        }

        public IkIndexElement Create(
            PositiveInt value)
        {
            IkIndexElement indexElement = null;

            try
            {
                indexElement = new kIndexElement(
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