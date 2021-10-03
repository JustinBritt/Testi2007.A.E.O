namespace Testi2007.A.E.O.Factories.Variables.TP
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Testi2007.A.E.O.Classes.Variables.TP;
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.TP;
    using Testi2007.A.E.O.Interfaces.Variables.TP;
    using Testi2007.A.E.O.InterfacesFactories.Variables.TP;

    internal sealed class TPxFactory : ITPxFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TPxFactory()
        {
        }

        public ITPx Create(
            VariableCollection<IiIndexElement, IjIndexElement, IwIndexElement> value)
        {
            ITPx variable = null;

            try
            {
                variable = new TPx(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return variable;
        }
    }
}