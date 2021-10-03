namespace Testi2007.A.E.O.Factories.Parameters.TP.WardDayPreferences
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Testi2007.A.E.O.Classes.Parameters.TP.WardDayPreferences;
    using Testi2007.A.E.O.Interfaces.ParameterElements.TP.WardDayPreferences;
    using Testi2007.A.E.O.Interfaces.Parameters.TP.WardDayPreferences;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.TP.WardDayPreferences;

    internal sealed class pFactory : IpFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public pFactory()
        {
        }

        public Ip Create(
            ImmutableList<IpParameterElement> value)
        {
            Ip parameter = null;

            try
            {
                parameter = new p(
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