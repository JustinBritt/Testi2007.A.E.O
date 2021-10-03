namespace Testi2007.A.E.O.Factories.Parameters.SP.WardOverrunTimes
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Testi2007.A.E.O.Classes.Parameters.SP.WardOverrunTimes;
    using Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardOverrunTimes;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.WardOverrunTimes;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.SP.WardOverrunTimes;

    internal sealed class oFactory : IoFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public oFactory()
        {
        }

        public Io Create(
            ImmutableList<IoParameterElement> value)
        {
            Io parameter = null;

            try
            {
                parameter = new o(
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