namespace Testi2007.A.E.O.Factories.ParameterElements.SP.WardSessionDemandMarginalBenefits
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Classes.ParameterElements.SP.WardSessionDemandMarginalBenefits;
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.SP;
    using Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardSessionDemandMarginalBenefits;
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.SP.WardSessionDemandMarginalBenefits;

    internal sealed class dParameterElementFactory : IdParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public dParameterElementFactory()
        {
        }

        public IdParameterElement Create(
            IjIndexElement jIndexElement,
            IkIndexElement kIndexElement,
            FhirDecimal value)
        {
            IdParameterElement parameterElement = null;

            try
            {
                parameterElement = new dParameterElement(
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

            return parameterElement;
        }
    }
}