namespace Testi2007.A.E.O.Factories.Parameters.SP.WardNumberSessionBounds
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Testi2007.A.E.O.Classes.Parameters.SP.WardNumberSessionBounds;
    using Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardNumberSessionBounds;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.WardNumberSessionBounds;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.SP.WardNumberSessionBounds;

    internal sealed class lFactory : IlFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public lFactory()
        {
        }

        public Il Create(
            ImmutableList<IlParameterElement> value)
        {
            Il parameter = null;

            try
            {
                parameter = new l(
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