namespace Testi2007.A.E.O.Factories.Parameters.SP.WardWaitingLists
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Testi2007.A.E.O.Classes.Parameters.SP.WardWaitingLists;
    using Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardWaitingLists;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.WardWaitingLists;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.SP.WardWaitingLists;

    internal sealed class WLFactory : IWLFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WLFactory()
        {
        }

        public IWL Create(
            ImmutableList<IWLParameterElement> value)
        {
            IWL parameter = null;

            try
            {
                parameter = new WL(
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