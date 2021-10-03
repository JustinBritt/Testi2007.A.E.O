namespace Testi2007.A.E.O.Factories.Parameters.SP.WardDemands
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Testi2007.A.E.O.Classes.Parameters.SP.WardDemands;
    using Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardDemands;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.WardDemands;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.SP.WardDemands;

    internal sealed class DFactory : IDFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DFactory()
        {
        }

        public ID Create(
            ImmutableList<IDParameterElement> value)
        {
            ID parameter = null;

            try
            {
                parameter = new D(
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