namespace Testi2007.A.E.O.Factories.CrossJoinElements.TP
{
    using System;

    using log4net;

    using Testi2007.A.E.O.Classes.CrossJoinElements.TP;
    using Testi2007.A.E.O.Interfaces.CrossJoinElements.TP;
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.TP;
    using Testi2007.A.E.O.InterfacesFactories.CrossJoinElements.TP;

    internal sealed class ijwCrossJoinElementFactory : IijwCrossJoinElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ijwCrossJoinElementFactory()
        {
        }

        public IijwCrossJoinElement Create(
            IiIndexElement iIndexElement,
            IjIndexElement jIndexElement,
            IwIndexElement wIndexElement)
        {
            IijwCrossJoinElement crossJoinElement = null;

            try
            {
                crossJoinElement = new ijwCrossJoinElement(
                    iIndexElement,
                    jIndexElement,
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