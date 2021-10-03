namespace Testi2007.A.E.O.Factories.Indices.SP
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Testi2007.A.E.O.Classes.Indices.SP;
    using Testi2007.A.E.O.Interfaces.IndexElements.SP;
    using Testi2007.A.E.O.Interfaces.Indices.SP;
    using Testi2007.A.E.O.InterfacesFactories.Indices.SP;

    internal sealed class kFactory : IkFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public kFactory()
        {
        }

        public Ik Create(
            ImmutableList<IkIndexElement> value)
        {
            Ik index = null;

            try
            {
                index = new k(
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