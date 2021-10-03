namespace Testi2007.A.E.O.Factories.Parameters.SP.OverrunTimes
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Classes.Parameters.SP.OverrunTimes;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.OverrunTimes;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.SP.OverrunTimes;

    internal sealed class HFactory : IHFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HFactory()
        {
        }

        public IH Create(
            Duration value)
        {
            IH parameter = null;

            try
            {
                parameter = new H(
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