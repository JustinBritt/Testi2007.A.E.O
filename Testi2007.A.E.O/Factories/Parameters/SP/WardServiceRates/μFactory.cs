namespace Testi2007.A.E.O.Factories.Parameters.SP.WardServiceRates
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Testi2007.A.E.O.Classes.Parameters.SP.WardServiceRates;
    using Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardServiceRates;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.WardServiceRates;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.SP.WardServiceRates;

    internal sealed class μFactory : IμFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public μFactory()
        {
        }

        public Iμ Create(
            ImmutableList<IμParameterElement> value)
        {
            Iμ parameter = null;

            try
            {
                parameter = new μ(
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