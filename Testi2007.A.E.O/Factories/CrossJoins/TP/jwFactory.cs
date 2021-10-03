namespace Testi2007.A.E.O.Factories.CrossJoins.TP
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Testi2007.A.E.O.Classes.CrossJoins.TP;
    using Testi2007.A.E.O.Interfaces.CrossJoinElements.TP;
    using Testi2007.A.E.O.Interfaces.CrossJoins.TP;
    using Testi2007.A.E.O.InterfacesFactories.CrossJoins.TP;

    internal sealed class jwFactory : IjwFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public jwFactory()
        {
        }

        public Ijw Create(
            ImmutableList<IjwCrossJoinElement> value)
        {
            Ijw crossJoin = null;

            try
            {
                crossJoin = new jw(
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