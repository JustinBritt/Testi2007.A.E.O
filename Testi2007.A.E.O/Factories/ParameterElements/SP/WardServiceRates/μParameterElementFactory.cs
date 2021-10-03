﻿namespace Testi2007.A.E.O.Factories.ParameterElements.SP.WardServiceRates
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Classes.ParameterElements.SP.WardServiceRates;
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardServiceRates;
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.SP.WardServiceRates;

    internal sealed class μParameterElementFactory : IμParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public μParameterElementFactory()
        {
        }

        public IμParameterElement Create(
            IjIndexElement jIndexElement,
            FhirDecimal value)
        {
            IμParameterElement parameterElement = null;

            try
            {
                parameterElement = new μParameterElement(
                    jIndexElement,
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