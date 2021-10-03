namespace Testi2007.A.E.O.Factories.Parameters.SP.NumberSessionBounds
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Classes.Parameters.SP.NumberSessionBounds;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.NumberSessionBounds;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.SP.NumberSessionBounds;

    internal sealed class qFactory : IqFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public qFactory()
        {
        }

        public Iq Create(
            PositiveInt value)
        {
            Iq parameter = null;

            try
            {
                parameter = new q(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameter;
        }
    }
}