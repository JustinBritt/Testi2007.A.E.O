namespace Testi2007.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Testi2007.A.E.O.Factories.ResultElements.SP.SurgeonSessionAssignments;
    using Testi2007.A.E.O.Factories.ResultElements.TP.OperatingRoomWardDayAssignments;
    using Testi2007.A.E.O.InterfacesAbstractFactories;
    using Testi2007.A.E.O.InterfacesFactories.ResultElements.SP.SurgeonSessionAssignments;
    using Testi2007.A.E.O.InterfacesFactories.ResultElements.TP.OperatingRoomWardDayAssignments;

    internal sealed class ResultElementsAbstractFactory : IResultElementsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ResultElementsAbstractFactory()
        {
        }

        public ISPxResultElementFactory CreateSPxResultElementFactory()
        {
            ISPxResultElementFactory factory = null;

            try
            {
                factory = new SPxResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ITPxResultElementFactory CreateTPxResultElementFactory()
        {
            ITPxResultElementFactory factory = null;

            try
            {
                factory = new TPxResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }
    }
}