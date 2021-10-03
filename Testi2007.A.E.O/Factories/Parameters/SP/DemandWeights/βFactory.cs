namespace Testi2007.A.E.O.Factories.Parameters.SP.DemandWeights
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Classes.Parameters.SP.DemandWeights;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.DemandWeights;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.SP.DemandWeights;

    internal sealed class βFactory : IβFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public βFactory()
        {
        }

        public Iβ Create(
            FhirDecimal value)
        {
            Iβ parameter = null;

            try
            {
                parameter = new β(
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