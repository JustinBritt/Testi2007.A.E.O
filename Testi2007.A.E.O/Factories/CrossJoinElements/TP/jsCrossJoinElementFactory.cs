namespace Testi2007.A.E.O.Factories.CrossJoinElements.TP
{
    using System;

    using log4net;

    using Testi2007.A.E.O.Classes.CrossJoinElements.TP;
    using Testi2007.A.E.O.Interfaces.CrossJoinElements.TP;
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.TP;
    using Testi2007.A.E.O.InterfacesFactories.CrossJoinElements.TP;

    internal sealed class jsCrossJoinElementFactory : IjsCrossJoinElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public jsCrossJoinElementFactory()
        {
        }

        public IjsCrossJoinElement Create(
            IjIndexElement jIndexElement,
            IsIndexElement sIndexElement)
        {
            IjsCrossJoinElement crossJoinElement = null;

            try
            {
                crossJoinElement = new jsCrossJoinElement(
                    jIndexElement,
                    sIndexElement);
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