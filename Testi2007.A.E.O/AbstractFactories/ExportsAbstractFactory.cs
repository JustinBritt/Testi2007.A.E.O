namespace Testi2007.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Testi2007.A.E.O.Factories.Exports.SP;
    using Testi2007.A.E.O.Factories.Exports.TP;
    using Testi2007.A.E.O.InterfacesAbstractFactories;
    using Testi2007.A.E.O.InterfacesFactories.Exports.SP;
    using Testi2007.A.E.O.InterfacesFactories.Exports.TP;

    internal sealed class ExportsAbstractFactory : IExportsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ExportsAbstractFactory()
        {
        }

        public ISPExportFactory CreateSPExportFactory()
        {
            ISPExportFactory factory = null;

            try
            {
                factory = new SPExportFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ITPExportFactory CreateTPExportFactory()
        {
            ITPExportFactory factory = null;

            try
            {
                factory = new TPExportFactory();
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