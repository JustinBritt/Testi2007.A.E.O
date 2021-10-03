namespace Testi2007.A.E.O.Factories.Indices.TP
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Testi2007.A.E.O.Classes.Indices.TP;
    using Testi2007.A.E.O.Interfaces.IndexElements.TP;
    using Testi2007.A.E.O.Interfaces.Indices.TP;
    using Testi2007.A.E.O.InterfacesFactories.Indices.TP;

    internal sealed class sFactory : IsFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public sFactory()
        {
        }

        public Is Create(
            ImmutableList<IsIndexElement> value)
        {
            Is index = null;

            try
            {
                index = new s(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return index;
        }
    }
}