namespace Testi2007.A.E.O.Factories.CrossJoins.SP
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Testi2007.A.E.O.Classes.CrossJoins.SP;
    using Testi2007.A.E.O.Interfaces.CrossJoinElements.SP;
    using Testi2007.A.E.O.Interfaces.CrossJoins.SP;
    using Testi2007.A.E.O.InterfacesFactories.CrossJoins.SP;

    internal sealed class jkFactory : IjkFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public jkFactory()
        {
        }

        public Ijk Create(
            ImmutableList<IjkCrossJoinElement> value)
        {
            Ijk crossJoin = null;

            try
            {
                crossJoin = new jk(
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