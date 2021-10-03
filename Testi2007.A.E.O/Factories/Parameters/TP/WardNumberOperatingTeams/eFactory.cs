namespace Testi2007.A.E.O.Factories.Parameters.TP.WardNumberOperatingTeams
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Testi2007.A.E.O.Classes.Parameters.TP.WardNumberOperatingTeams;
    using Testi2007.A.E.O.Interfaces.ParameterElements.TP.WardNumberOperatingTeams;
    using Testi2007.A.E.O.Interfaces.Parameters.TP.WardNumberOperatingTeams;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.TP.WardNumberOperatingTeams;

    internal sealed class eFactory : IeFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public eFactory()
        {
        }

        public Ie Create(
            ImmutableList<IeParameterElement> value)
        {
            Ie parameter = null;

            try
            {
                parameter = new e(
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