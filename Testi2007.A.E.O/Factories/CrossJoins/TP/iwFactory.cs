namespace Testi2007.A.E.O.Factories.CrossJoins.TP
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Testi2007.A.E.O.Classes.CrossJoins.TP;
    using Testi2007.A.E.O.Interfaces.CrossJoinElements.TP;
    using Testi2007.A.E.O.Interfaces.CrossJoins.TP;
    using Testi2007.A.E.O.InterfacesFactories.CrossJoins.TP;

    internal sealed class iwFactory : IiwFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public iwFactory()
        {
        }

        public Iiw Create(
            ImmutableList<IiwCrossJoinElement> value)
        {
            Iiw crossJoin = null;

            try
            {
                crossJoin = new iw(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return crossJoin;
        }
    }
}