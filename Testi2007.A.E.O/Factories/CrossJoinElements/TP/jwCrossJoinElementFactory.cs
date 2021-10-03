namespace Testi2007.A.E.O.Factories.CrossJoinElements.TP
{
    using System;

    using log4net;

    using Testi2007.A.E.O.Classes.CrossJoinElements.TP;
    using Testi2007.A.E.O.Interfaces.CrossJoinElements.TP;
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.TP;
    using Testi2007.A.E.O.InterfacesFactories.CrossJoinElements.TP;

    internal sealed class jwCrossJoinElementFactory : IjwCrossJoinElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public jwCrossJoinElementFactory()
        {
        }

        public IjwCrossJoinElement Create(
            IjIndexElement jIndexElement,
            IwIndexElement wIndexElement)
        {
            IjwCrossJoinElement crossJoinElement = null;

            try
            {
                crossJoinElement = new jwCrossJoinElement(
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