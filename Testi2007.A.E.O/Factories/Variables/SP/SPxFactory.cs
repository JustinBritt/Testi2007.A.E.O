namespace Testi2007.A.E.O.Factories.Variables.SP
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Testi2007.A.E.O.Classes.Variables.SP;
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.SP;
    using Testi2007.A.E.O.Interfaces.Variables.SP;
    using Testi2007.A.E.O.InterfacesFactories.Variables.SP;

    internal sealed class SPxFactory : ISPxFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SPxFactory()
        {
        }

        public ISPx Create(
            VariableCollection<IjIndexElement, IkIndexElement> value)
        {
            ISPx variable = null;

            try
            {
                variable = new SPx(
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