namespace Testi2007.A.E.O.Factories.Indices.TP
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Testi2007.A.E.O.Classes.Indices.TP;
    using Testi2007.A.E.O.Interfaces.IndexElements.TP;
    using Testi2007.A.E.O.Interfaces.Indices.TP;
    using Testi2007.A.E.O.InterfacesFactories.Indices.TP;

    internal sealed class iFactory : IiFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public iFactory()
        {
        }

        public Ii Create(
            ImmutableList<IiIndexElement> value)
        {
            Ii index = null;

            try
            {
                index = new i(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return index;
        }
    }
}