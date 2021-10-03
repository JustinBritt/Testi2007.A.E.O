namespace Testi2007.A.E.O.Factories.Parameters.TP.WardNumberAssignedSessions
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Testi2007.A.E.O.Classes.Parameters.TP.WardNumberAssignedSessions;
    using Testi2007.A.E.O.Interfaces.ParameterElements.TP.WardNumberAssignedSessions;
    using Testi2007.A.E.O.Interfaces.Parameters.TP.WardNumberAssignedSessions;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.TP.WardNumberAssignedSessions;

    internal sealed class NFactory : INFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public NFactory()
        {
        }

        public IN Create(
            ImmutableList<INParameterElement> value)
        {
            IN parameter = null;

            try
            {
                parameter = new N(
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