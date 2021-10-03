namespace Testi2007.A.E.O.Factories.Indices.TP
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Testi2007.A.E.O.Classes.Indices.TP;
    using Testi2007.A.E.O.Interfaces.IndexElements.TP;
    using Testi2007.A.E.O.Interfaces.Indices.TP;
    using Testi2007.A.E.O.InterfacesFactories.Indices.TP;

    internal sealed class wFactory : IwFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public wFactory()
        {
        }

        public Iw Create(
            ImmutableList<IwIndexElement> value)
        {
            Iw index = null;

            try
            {
                index = new w(
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