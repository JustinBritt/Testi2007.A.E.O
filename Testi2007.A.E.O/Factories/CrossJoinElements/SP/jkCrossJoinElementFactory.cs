namespace Testi2007.A.E.O.Factories.CrossJoinElements.SP
{
    using System;

    using log4net;

    using Testi2007.A.E.O.Classes.CrossJoinElements.SP;
    using Testi2007.A.E.O.Interfaces.CrossJoinElements.SP;
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.SP;
    using Testi2007.A.E.O.InterfacesFactories.CrossJoinElements.SP;

    internal sealed class jkCrossJoinElementFactory : IjkCrossJoinElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public jkCrossJoinElementFactory()
        {
        }

        public IjkCrossJoinElement Create(
            IjIndexElement jIndexElement,
            IkIndexElement kIndexElement)
        {
            IjkCrossJoinElement crossJoinElement = null;

            try
            {
                crossJoinElement = new jkCrossJoinElement(
                    jIndexElement,
                    kIndexElement);
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