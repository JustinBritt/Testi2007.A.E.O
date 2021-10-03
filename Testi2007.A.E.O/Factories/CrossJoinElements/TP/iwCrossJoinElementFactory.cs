namespace Testi2007.A.E.O.Factories.CrossJoinElements.TP
{
    using System;

    using log4net;

    using Testi2007.A.E.O.Classes.CrossJoinElements.TP;
    using Testi2007.A.E.O.Interfaces.CrossJoinElements.TP;
    using Testi2007.A.E.O.Interfaces.IndexElements.TP;
    using Testi2007.A.E.O.InterfacesFactories.CrossJoinElements.TP;

    internal sealed class iwCrossJoinElementFactory : IiwCrossJoinElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public iwCrossJoinElementFactory()
        {
        }

        public IiwCrossJoinElement Create(
            IiIndexElement iIndexElement,
            IwIndexElement wIndexElement)
        {
            IiwCrossJoinElement crossJoinElement = null;

            try
            {
                crossJoinElement = new iwCrossJoinElement(
                    iIndexElement,
                    wIndexElement);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return crossJoinElement;
        }
    }
}