namespace Testi2007.A.E.O.Factories.ParameterElements.SP.WardOverrunTimes
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Classes.ParameterElements.SP.WardOverrunTimes;
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardOverrunTimes;
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.SP.WardOverrunTimes;

    internal sealed class oParameterElementFactory : IoParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public oParameterElementFactory()
        {
        }

        public IoParameterElement Create(
            IjIndexElement jIndexElement,
            Duration value)
        {
            IoParameterElement parameterElement = null;

            try
            {
                parameterElement = new oParameterElement(
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