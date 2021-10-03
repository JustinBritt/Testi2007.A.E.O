namespace Testi2007.A.E.O.Factories.Parameters.TP.WardWaitingLists
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Testi2007.A.E.O.Classes.Parameters.TP.WardWaitingLists;
    using Testi2007.A.E.O.Interfaces.ParameterElements.TP.WardWaitingLists;
    using Testi2007.A.E.O.Interfaces.Parameters.TP.WardWaitingLists;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.TP.WardWaitingLists;

    internal sealed class WLSSFactory : IWLSSFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WLSSFactory()
        {
        }

        public IWLSS Create(
            ImmutableList<IWLSSParameterElement> value)
        {
            IWLSS parameter = null;

            try
            {
                parameter = new WLSS(
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